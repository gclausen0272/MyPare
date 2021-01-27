
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AngleSharp.Html.Parser;
using AngleSharp.Html.Dom;
using AngleSharp.Dom;
using System.Net.Http;
using System.Threading;
using System.IO;
using HtmlAgilityPack;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
namespace Pare.Controllers
{
    public class ApplicationController : Controller
    {

    internal string ScrapeWebsite(string url)
    {
        Console.WriteLine(url);
        var timer = new Stopwatch();
        System.Net.ServicePointManager.Expect100Continue = false;

        timer.Start();

            url = url.Split("?")[0];
                 WebRequest.DefaultWebProxy = null;
                var request = (HttpWebRequest)WebRequest.Create(url);
                 timer.Stop();
                 Console.WriteLine(timer.Elapsed.TotalMilliseconds + " time for request ");   
                 timer.Reset();
                timer.Start();
                var response = (HttpWebResponse)request.GetResponse();
                 timer.Stop();
                 Console.WriteLine(timer.Elapsed.TotalMilliseconds + " time for response ");   
                 timer.Reset();
                timer.Start();
                var reader = new StreamReader(response.GetResponseStream());

                string line ="";

                // // Stream data  = client.OpenRead(url);
                 timer.Stop();
                 Console.WriteLine(timer.Elapsed.TotalMilliseconds + " time for streamReader ");   
                 timer.Reset();
                timer.Start();
                // StreamReader reader = new StreamReader(data);
                while ((line = reader.ReadLine()) != null)
                {
                    if(line.Contains("fullMenuUrl")){
                        string ret =  GetUrlSubstring(line,"fullMenuUrl","fullMenuUrl" );
                        timer.Stop();
                        Console.WriteLine(timer.Elapsed.TotalMilliseconds + " reading and processing");   
                    response.Close();
                        return ret;
                    }
                 }
                 timer.Stop();
                 Console.WriteLine(timer.Elapsed.TotalMilliseconds + " reading and processing"); 
                 response.Close();

               return "no menu";
            }
    // }
    public static string GetUrlSubstring(string text, string stopAt, string start){
        int st = text.IndexOf(start);
        if(st<1){
            return "no menu avalible";
        }
        int numQuotes = 2;
        int i = st;
        while(numQuotes>=0){
            if((char)text[i] == '"'){
                numQuotes--;
            }
            i++;

        }
        i--;
        // Console.WriteLine(text.Substring(st,(i)-st));
        Console.WriteLine("here");
        string str = text.Substring(st,i-st).Replace("fullMenuUrl\": ", "").Replace("\"", "");
        // Console.WriteLine(str);

        if(!str.Contains("yelp")){
                str = "https://www.yelp.com" + str;
        }
        return str;
    }

    private string getUrlForMenu(string[] l){
        string ans = "";
        int i = 0; 
        // fullMenuUrl":
        // Console.WriteLine(k.Count());
        // https://www.yelp.com/
        foreach (string s in l){
            i++;
            if(s.Contains("fullMenuUrl")){
                Console.WriteLine(i);
                Console.WriteLine(s);
            ans = s.Substring(16).Replace("\"", "");;
            if(!s.Contains("yelp")){
                ans = "https://www.yelp.com/" + ans;
            }
            break;
         }

        }
        return ans;
    }
        public ActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult> Landing()
        {   
            
            int id = 0;
            var db =await new EFCoreWebDemoContext().Restaurants.ToArrayAsync();
            id = db[db.Length-1].SessionID;
            id++;
            ViewBag.Message = id;
            return View();
        }
        

        //returns pair if there is one else returns first res 
        public Restaurant isPair(Array p){
            Restaurant ret = new Restaurant();
            foreach(Restaurant rest in p){
                ret = rest;
                if(rest.Score>1){
                    return rest;
                }
            }
            return ret;
        }
        private string toMenuUrl(string url){
            return url.Replace("biz","menu").Split("?")[0];
        }
        private string toMenuPhotoUrl(string url){
            // https://www.yelp.com/biz_photos/dirty-birds-omaha?tab=menu
            return url.Replace("biz","biz_photos").Split("?")[0] + "?tab=menu";
  
        }
        private string getTop(List<Restaurant> rest){
            string st = "";
            rest.Sort((emp1,emp2) =>emp1.Score.CompareTo(emp2.Score));
            int num = (int)(rest.Count*.1);
            for(int i = 0; i< num; i++){
                st+= rest[i].Name + " ";
            }
            return st;
        }
        public async Task<ActionResult> CreateMatches(int sessionId, int index=0, int score=0, string name="Something went wrong on our end!", int enough=2, bool first = false){
            ViewBag.Enough = enough;
            using (var d = new EFCoreWebDemoContext()){
                var res = await d.Restaurants.Where(k => k.SessionID == sessionId).Where(b => (b.Name == name)).ToArrayAsync();
                var result = res[0];
                if (result != null){ 
                    result.Score = result.Score+score;
                    d.SaveChanges();
                }
            }
            var db =await new EFCoreWebDemoContext().Restaurants.Where(r=> r.SessionID == sessionId).ToArrayAsync();
            var maybe = isPair(db);
            if(maybe.Score>=enough){
                ViewBag.url = maybe.Url;
                
                ViewBag.ImageUrl= maybe.ImageUrl;
                ViewBag.Description = maybe.Description;
                ViewBag.Message = "we found a pair!!  " + maybe.Name;
                return View();
            }else{
                if(!first){
                 index++;
                }
                if(index>=db.Length){
                    List<Restaurant> r = db.ToList();

                    ViewBag.Message = "Oof thats all of them. Sorry we couldnt help! but heres your top matches " + getTop(r);
                    return View();
                }
                else{
                    name = db[index].Name;
                    ViewBag.name = db[index].Name;
                    score = 0;
                    // Console.WriteLine(ScrapeWebsite(db[index].Url));
                    // Console.WriteLine(db[index].Description);
                    ViewBag.Description = db[index].Description;
                    ViewBag.sessionId = sessionId;
                    ViewBag.menu =toMenuUrl(db[index].Url);
                    ViewBag.menuPhoto = toMenuPhotoUrl(db[index].Url);
                    ViewBag.index = index;
                    ViewBag.score = db[index].Score;
                    ViewBag.ImageUrl = db[index].ImageUrl;
                    ViewBag.Url = db[index].Url;
                    string add = "No match yet: how about " + name+ " ?";
                    ViewBag.Message = add;
                    return View();
                } 
            }

        }
        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
        private const string API_VERSION = "/v3";
        public string arrayToString(Array s){
            string ans = "";
            foreach(Yelp.Api.Models.Category str in s ){
                ans += " "+ str.Title;
            }
            return ans;
        }
        public string arrayToString2(Array s){
            string ans = "";
            foreach(string str in s ){
                ans += " "+ str;
            }
            return ans;
        }
        public async Task<ActionResult> Populate(string term, string location, int maxLocations, int sessionId, int enough ){
            int offset = 0;
            ViewBag.sessionId = sessionId;
            ViewBag.enough = enough;
            //creates the client 
            var client = new Yelp.Api.Client("4WgqC1MIi3IvdAaLa9H4i3EFbSZvbhNZN-89cqASmQElUsYH8hc89_UapfP0XKTbUgOoQp10q_3Me1vfH2VaTBh_dNnTld4GMQuMdHYdNAObPiDBt1Ts6w0V3qcAYHYx");
            Yelp.Api.Models.SearchRequest sr = new Yelp.Api.Models.SearchRequest();
            sr.Location = location; 
            sr.Term = "restaurants " + term;    
            Boolean fir = true;

            //creates return info       
            string ans = "";
            IList rest = new ArrayList(maxLocations);
            //breakes it into managable chunks 
            if(maxLocations>50){
                while(maxLocations>50){

                    //breaks into chunk of 50
                    maxLocations-=50;

                    //creates larger offset 
                    offset+=50;
                    sr.MaxResults = 50;
                    sr.ResultsOffset = offset;

                    //fetches results 
                    var results = await client.SearchBusinessesAllAsync(sr);
                    IList<Yelp.Api.Models.BusinessResponse> bus =  results.Businesses;

                    //iterates 
                    for(int i = 0; i<sr.MaxResults; i++ ){
                        if(fir){
                         ViewBag.first =  bus[i].Name;
                         fir= false;
                        }
                        //   Console.WriteLine(arrayToString(bus[i].Categories) + " hello");

                        ans +=  bus[i].Name +", ";
                        //creates res object 
                        Restaurant r = new Restaurant();
                        r.Name = bus[i].Name;
                        r.SessionID = sessionId;
                        r.Score = 0;
                        // r.menuUrl = ScrapeWebsite(bus[i].Url);

                        r.Description = arrayToString(bus[i].Categories) + "- rating: " + bus[i].Rating +"- address: "+arrayToString2(bus[i].Location.DisplayAddress);
                        r.Url = bus[i].Url;
                        r.ImageUrl = bus[i].ImageUrl;
                        //adds to list 
                        rest.Add(r);
                    }
                }
            }
            
            //gets the leftover objects 
            if(maxLocations>0){
                sr.MaxResults = maxLocations;
                sr.ResultsOffset = offset;

                    var results = await client.SearchBusinessesAllAsync(sr);
                    IList<Yelp.Api.Models.BusinessResponse> bus =  results.Businesses;
                    for(int i = 0; i<sr.MaxResults; i++ ){
                        if(fir){
                         ViewBag.first =  bus[i].Name;
                         fir= false;
                        }
                    // foreach(Yelp.Api.Models.BusinessResponse b in bus){
                        ans +=  bus[i].Name+ ", ";
                        Restaurant r = new Restaurant();
                        r.Name = bus[i].Name;
                        //   Console.WriteLine(arrayToString(bus[i].Categories) + " hello");

                        if(ContainsRest(bus[i].Name, rest)){
                            r.Name+=" ";
                        }
                        r.SessionID = sessionId;
                        r.Description = arrayToString(bus[i].Categories) + "- rating: " + bus[i].Rating +"- address: "+arrayToString2(bus[i].Location.DisplayAddress);
                        r.Url = bus[i].Url;
                        // r.menuUrl = ScrapeWebsite(bus[i].Url);

                        r.ImageUrl = bus[i].ImageUrl;
                        rest.Add(r);
                    }                
            }

            //entity fw updates data base 
           ICollection<Restaurant> db =await new EFCoreWebDemoContext().Restaurants.ToArrayAsync();
                using (var context = new EFCoreWebDemoContext())
                {
                foreach (Restaurant a in rest ){         
                    context.Add(a);
                }

                //saves changes 
                await context.SaveChangesAsync();
            
                ViewBag.Message = ans;
                ViewBag.NumTimes = 1;
                return View();
            }
        }
        private bool ContainsRest(string name, IList r)
        {
            foreach(Restaurant rest in r)
            {
                if(rest.Name.Equals(name)){
                    return true;
                }
            }

            return false;
        }
    }
}