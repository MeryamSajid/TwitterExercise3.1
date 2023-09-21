using System;

class Program {
  public static void Main (string[] args) {

    string tweet;
    
    Console.WriteLine ("Type your tweet: ");
    tweet = Console.ReadLine();
    int tweetLength = tweet.Length;
        
  if (tweetLength <= 140 ) {
    Console.WriteLine ("Posted");
    
  } else {
    Console.WriteLine ("Rejected");
    }

    
  }
  
}