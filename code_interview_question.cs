using System;
					
public class Program
{
	
	public static int findMissedNumberVer1(int[] arr)
	{
		int ret=-1;
		
		
		bool[] newArr=new bool[arr.Length+2];
		
		newArr[0]=true;
		for (int i = 1; i < newArr.Length; i++)
        {
           newArr[i]=false;
        }
		
		
		for (int i = 0; i < arr.Length; i++)
        {
           newArr[arr[i]]=true;
        }
		
		for (int i = 0; i < newArr.Length; i++)
        {
           if(newArr[i]==false)
		   {
			   ret=i;
			  	return ret;
		   }
        }
		
		
		return ret;
		
	}

	public static int findMissedNumberVer2(int[] arr)
	{
		int ret=-1;
		
		int sum=0;
		
		
		for (int i = 0; i < arr.Length; i++)
        {
           sum+=arr[i];
        }
		
		int originalSize=arr.Length + 1;
		int sumOriginalArray = (((originalSize+1) )*originalSize)/2;
		
		ret=sumOriginalArray-sum;
		return ret;
		
	}

	
	
	public static void SolveQuadratic(float a, float b, float c, out float x1, out float x2)
	{
		//Calculate the inside of the square root
		float insideSquareRoot = (b * b) - 4 * a * c;

		if (insideSquareRoot < 0)
		{
			//There is no solution
			x1 = float.NaN;
			x2 = float.NaN;
		}
		else
		{
			//Compute the value of each x
			//if there is only one solution, both x's will be the same
			float t = (float)(-0.5f * (b + Math.Sign(b) * Math.Sqrt(insideSquareRoot)));
			x1 = c / t;
			x2 = t / a;
		}
	}
	public static void findTwoMissedNumberVer1(int[] arr, out int ret1,out int ret2)
	{
	
		int sum=0;
		int multiple=1;
		
		for (int i = 0; i < arr.Length; i++)
        {
           sum+=arr[i];
		   multiple*=arr[i];
        }
		
		int originalSize=arr.Length + 2;
		
		int sumOriginalArray = (((originalSize+1) )*originalSize)/2;
		int sumRes=sumOriginalArray-sum;
		
		int multRes=1;
		for (int i = 1; i <= originalSize; i++)
        {
			multRes*=i;
        }
		multRes=multRes/multiple;

		
		int a=1;
		int b= sumRes*-1;
		int c=multRes;
		
		float x1,x2;

		SolveQuadratic(a,b,c,out x1,out x2);
		
		Console.WriteLine("SolveQuadratic  x1 = {0}  x2 = {1} ,a = {2} b = {3} c = {4}  " ,x1.ToString(),x2.ToString(),a.ToString(),b.ToString(),c.ToString());
		ret1=(int)x1;
		ret2=(int)x2;
		Console.WriteLine("ret1 = {0}  ret2 = {1}" ,ret1.ToString(),ret2.ToString());
	}

	
	public static void Main()
	{
		int[] numbers = { 1,2,3,4};
		int ret1,ret2;
		findTwoMissedNumberVer1(numbers,out ret1,out ret2);
		//Console.WriteLine(.ToString());
	}
}