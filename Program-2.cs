using System;
namespace Homework3{

  class Program
{
    static void Main(string[] arg)
    {
        string dnaSequence = "ATCGGTA";

        string replicatedDNA = ReplicateDNA(dnaSequence);
        
        Console.WriteLine("Original DNA: " + dnaSequence);
        Console.WriteLine("Replicated DNA: " + replicatedDNA);
    }
    Console.Write("Do you want to replicate it? (Y/N): ");
    string Yes = "y";
    string No = "n";

    if(Yes != y || No != n){
      Console.WriteLine("Please input Y or N");
    }
        static bool IsValidSequence(string halfDNASequence)
{
	foreach(char nucleotide in halfDNASequence)
	{
    	if(!"ATCG".Contains(nucleotide))
    	{
        	return false;
    	}
	}
	return true;
}
      Console.Write("Replicated half DNA sequence :");

    static string ReplicateSeqeunce(string halfDNASequence)
{
	string result = "";
	foreach(char nucleotide in halfDNASequence)
	{
    	result += "TAGC"["ATCG".IndexOf(nucleotide)];
	}
	return result;
}
    Console.Write("Do you want to process another sequence ? (Y/N) : " );
  if(No = n){
    Console.Write("finish");
  }
  return;
  }
}
