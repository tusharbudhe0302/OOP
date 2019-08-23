using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code
{
    class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Please Enter Choice");
                Console.WriteLine("0. Quit");
                Console.WriteLine("1. Two Sum");
                Console.WriteLine("2. Two Array Mutiplication");
                Console.WriteLine("3.  Best Time to Buy and Sell Stock");
                Console.WriteLine("4.  Product of Array Except Self ");
                Console.WriteLine("5.  Product of Array Except Self Memory Optimization ");
                Console.WriteLine("6.  Roman to Int");
                Console.WriteLine("7.  Add Two Number of list is already in reverse Order");
                Console.WriteLine("8.  Add Two Number Not using System.Collections.Generic");
                Console.WriteLine("9. Merge Two Sorted List");
                Console.WriteLine("10. findMaxSubArraySumEqualsk : ");
                Console.WriteLine("11. Squre Sorted Array ");
                Console.WriteLine("12. Custom Sort String  Liner Sort Algo ");
                Console.WriteLine("13. Custom Sort String  Recursive Merge Sort Algo ");
                Console.WriteLine("14. Swap For Longest Repeated Character Substring");
                Console.WriteLine("15. Palindrome ");
                Console.WriteLine("16. Pascal Tree ");
                Console.WriteLine("17.  Array Should Only if matches to chars Param Leet Code Weekly ");
                Console.WriteLine("18.  Longest Sub String");
                Console.WriteLine("19.  High Proirty Longest Sub String");
                int choice = Convert.ToInt32(Console.ReadLine());
                int[] prod, result;
                if (choice == 0)
                {
                    Console.WriteLine("Program Ends..");
                    return;
                }
                solution sln = new solution();
                switch (choice)
                {
                    case 1:
                        #region Case 1
                        Console.WriteLine("Please enter maximum number to genrate array ");
                        int size = Convert.ToInt32(Console.ReadLine());
                        int[] arrayInPut = new int[size];
                        for (int i = 0; i < size; i++)
                        {
                            Console.WriteLine("Please enter Number ");
                            int inputNumber = Convert.ToInt32(Console.ReadLine());
                            arrayInPut[i] = inputNumber;
                        }
                        Console.WriteLine("Please enter target ");
                        int inputTarget = Convert.ToInt32(Console.ReadLine());
                        result = sln.TwoSum(arrayInPut, inputTarget);
                        break;
                    #endregion
                    case 2:
                        #region Case 2
                        int[,] array1 = new int[,]
                        {
                            {1,2,3 },
                            {1,2,3 },
                            {1,2,3 }
                       };
                        int[,] array2 = new int[,]
                       {
                            {1},
                            {1},
                           {1}

                      };
                        sln.MultiplicationOfTwoDimetionArray(array1, array2);
                        break;
                    #endregion
                    case 3:
                        #region Case 3
                        StockQuestion Q = new StockQuestion();
                        int[] price = new int[6];
                        price[0] = 7;
                        price[1] = -8;
                        price[2] = 20;
                        price[3] = 3;
                        price[4] = 6;
                        price[5] = 4;
                        int maxProfit = Q.MaxProfit(price);
                        Console.WriteLine("Max Profit : " + maxProfit);
                        break;
                    #endregion
                    case 4:
                        #region Case 4
                        ProductOfArrayItSelf prd = new ProductOfArrayItSelf();
                        //int[] prod = new int[4];
                        //prod[0] = 1;
                        //prod[1] = 2;
                        //prod[2] = 3;
                        //prod[3] = 4;
                        //10, 3, 5, 6, 2
                        prod = new int[5];
                        prod[0] = 10;
                        prod[1] = 3;
                        prod[2] = 5;
                        prod[3] = 6;
                        prod[4] = 2;

                        int[] resultProd = prd.ProductOfArray(prod, prod.Length);
                        Console.WriteLine("Array Product is :");
                        for (int i = 0; i < resultProd.Length; i++)
                        {
                            Console.Write(resultProd[i] + " ");
                        }
                        Console.WriteLine();
                        break;
                    #endregion
                    case 5:
                        #region Case 5
                        ProductOfArrayItSelf prdMemory = new ProductOfArrayItSelf();
                        prod = new int[5];
                        prod[0] = 10;
                        prod[1] = 3;
                        prod[2] = 5;
                        prod[3] = 6;
                        prod[4] = 2;
                        result = prdMemory.ProductOfArrayMemoryOptimization(prod, prod.Length);
                        Console.WriteLine("Array Product Memory Optimization is :");
                        for (int i = 0; i < result.Length; i++)
                        {
                            Console.Write(result[i] + " ");
                        }
                        Console.WriteLine();
                        break;
                    #endregion
                    case 6:
                        #region Case 6
                        Console.WriteLine("Please enter Roman Combination Of Number : I  V  X L C D M ");
                        string input = Console.ReadLine();
                        RomanToInt roman = new RomanToInt();
                        int romainToIntResult = roman.RomanToIntConverter(input);
                        Console.WriteLine("Romain to int : " + romainToIntResult);
                        break;
                    #endregion
                    case 7:
                        #region Case 7
                        ArrayTwoNumber arn = new ArrayTwoNumber();
                        List<int> lstAddTwoNumber = arn.AddNumbers();
                        Console.WriteLine("Addition Of Number 555 + 175 ");
                        foreach (int i in lstAddTwoNumber)
                        {
                            Console.Write(i);
                        }
                        Console.WriteLine();
                        break;
                    #endregion
                    case 8:
                        #region Case 8
                        ArrayTwoNumber arn2 = new ArrayTwoNumber();
                        ListNode l1, l2;
                        ListNode l1temp8 = new ListNode(8);
                        ListNode l1temp1 = new ListNode(1);
                        l1temp1.next = l1temp8;
                        ListNode l2temp0 = new ListNode(0);
                        l1 = l1temp1;
                        l2 = l2temp0;
                        arn2.AddNumberNoGenrics(l1, l2);
                        break;
                    #endregion
                    case 9:
                        #region Case 9
                        MergeTwoList mg = new MergeTwoList();
                        ListNode lmg1 = new ListNode(1);
                        lmg1.next = new ListNode(2);
                        lmg1.next.next = new ListNode(4);
                        ListNode lmg2 = new ListNode(1);
                        lmg2.next = new ListNode(3);
                        lmg2.next.next = new ListNode(4);
                        mg.MergeTwoLists(lmg1, lmg2);
                        break;
                    #endregion
                    case 10:
                        #region Case 10
                        //int[] baseArray = new int[6];
                        //baseArray[0] = 10;
                        //baseArray[1] = 5;
                        //baseArray[2] = 2;
                        //baseArray[3] = 7;
                        //baseArray[4] = 1;
                        //baseArray[5] = 9;
                        //int k = 15;
                        int[] baseArray = new int[5];
                        baseArray[0] = 1;
                        baseArray[1] = -1;
                        baseArray[2] = 5;
                        baseArray[3] = -2;
                        baseArray[4] = 7;
                        int k = 3;
                        int maxLength = MaximumSizeSubarray.findMaxSubArraySumEqualsk(baseArray, k);
                        Console.WriteLine("Max length :" + maxLength);
                        break;
                    #endregion
                    case 11:
                        #region Case 11
                        SqureSortedArray sq = new SqureSortedArray();
                        int[] sotedArrayIP = { -4, -1, 0, 3, 10 };
                        int[] resultSet = sq.SortedSumArray(sotedArrayIP);
                        break;
                    #endregion
                    case 12:
                        #region Case 12
                        CustomSortString cstm = new CustomSortString();
                        Console.WriteLine("Please enter string s in lowser case : ");
                        string S = Console.ReadLine().ToLower();
                        Console.WriteLine("Please enter string T in lowser case : ");
                        string T = Console.ReadLine().ToLower();
                        string linserSearchOP = cstm.customSortStringLiner(S, T);
                        Console.WriteLine("OP : " + linserSearchOP);
                        break;
                    #endregion
                    case 13:
                        #region Case 13
                        CustomSortString cstm2 = new CustomSortString();
                        Console.WriteLine("Please enter string s in lowser case : ");
                        string Sm = Console.ReadLine().ToLower();
                        Console.WriteLine("Please enter string T in lowser case : ");
                        string Tm = Console.ReadLine().ToLower();
                        string linserSearchOPm = cstm2.customSortStringMergeSort(Sm, Tm);
                        Console.WriteLine("OP : " + linserSearchOPm);
                        break;
                    #endregion
                    case 14:
                        #region Case 14
                        Console.WriteLine("Please enter string To SwapLongestRepeatedCharacterSubstring");
                        string longString = Console.ReadLine();
                        SwapLongestRepeatedCharacterSubstring slrch = new SwapLongestRepeatedCharacterSubstring();
                        int maxRepatedafterSwap = slrch.MaxRepOpt1(longString);
                        Console.WriteLine(" Result Of Max Swap : " + maxRepatedafterSwap);
                        break;
                    #endregion
                    case 15:
                        #region Case 15
                        Console.WriteLine("Please enter string of your choice");
                        string Palinedrome = Console.ReadLine();
                        Palindrome.PrintPalidrom(Palinedrome);
                        break;
                    #endregion
                    case 16:
                        #region Case 16
                        PascalTraingle pascalT = new PascalTraingle();
                        Console.WriteLine("Please enter number for pascal traingle ");
                        int pascalNumber = Convert.ToInt32(Console.ReadLine());
                        var intList = pascalT.Generate(pascalNumber);
                        foreach (var el in intList)
                        {
                            Console.WriteLine();
                            foreach (var eel2 in el)
                            {
                                Console.Write(eel2);
                            }
                        }
                        Console.WriteLine();
                        break;
                    #endregion
                    case 17:
                        #region Case 17
                        CountCharacters chCount = new CountCharacters();
                        string[] words = { "dyiclysmffuhibgfvapygkorkqllqlvokosagyelotobicwcmebnpznjbirzrzsrtzjxhsfpiwyfhzyonmuabtlwin", "ndqeyhhcquplmznwslewjzuyfgklssvkqxmqjpwhrshycmvrb", "ulrrbpspyudncdlbkxkrqpivfftrggemkpyjl", "boygirdlggnh", "xmqohbyqwagkjzpyawsydmdaattthmuvjbzwpyopyafphx", "nulvimegcsiwvhwuiyednoxpugfeimnnyeoczuzxgxbqjvegcxeqnjbwnbvowastqhojepisusvsidhqmszbrnynkyop", "hiefuovybkpgzygprmndrkyspoiyapdwkxebgsmodhzpx", "juldqdzeskpffaoqcyyxiqqowsalqumddcufhouhrskozhlmobiwzxnhdkidr", "lnnvsdcrvzfmrvurucrzlfyigcycffpiuoo", "oxgaskztzroxuntiwlfyufddl", "tfspedteabxatkaypitjfkhkkigdwdkctqbczcugripkgcyfezpuklfqfcsccboarbfbjfrkxp", "qnagrpfzlyrouolqquytwnwnsqnmuzphne", "eeilfdaookieawrrbvtnqfzcricvhpiv", "sisvsjzyrbdsjcwwygdnxcjhzhsxhpceqz", "yhouqhjevqxtecomahbwoptzlkyvjexhzcbccusbjjdgcfzlkoqwiwue", "hwxxighzvceaplsycajkhynkhzkwkouszwaiuzqcleyflqrxgjsvlegvupzqijbornbfwpefhxekgpuvgiyeudhncv", "cpwcjwgbcquirnsazumgjjcltitmeyfaudbnbqhflvecjsupjmgwfbjo", "teyygdmmyadppuopvqdodaczob", "qaeowuwqsqffvibrtxnjnzvzuuonrkwpysyxvkijemmpdmtnqxwekbpfzs", "qqxpxpmemkldghbmbyxpkwgkaykaerhmwwjonrhcsubchs" };
                        chCount.Countcharacters(words, "usdruypficfbpfbivlrhutcgvyjenlxzeovdyjtgvvfdjzcmikjraspdfp");
                        break;
                    #endregion
                    case 18:
                        #region
                        StringOfParentheses st = new StringOfParentheses();
                        Console.WriteLine("Please enter string you wnat to check");
                        string ipParentheses = Console.ReadLine();
                        string opParentheses = st.StringOfParenthesesReturn(ipParentheses);
                        Console.WriteLine(opParentheses);
                        break;
                    #endregion
                    case 19:
                        #region
                        StringOfParentheses stLeet = new StringOfParentheses();
                        Console.WriteLine("Please enter string you want to check");
                        string ipString = Console.ReadLine();
                        string resultOPParentheses = stLeet.LongestLavidParenthese(ipString);
                        Console.WriteLine(resultOPParentheses);
                        break;
                    #endregion

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                        Console.ReadLine();
                }
            }
        }
    }

}
