using System;


namespace _20240321
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 建立 RoleName[0]~RoleName[4] 用來存放角色姓名
            string[] RoleName = { "魯夫", "喬巴", "羅賓", "香吉士", "騙人布" };
            // 建立 Money[0]~Money[4] 用來存放角色的懸賞金額
            int[] Money = { 1500000000, 100, 130000000, 330000000, 200000000 };

            Console.WriteLine("= = 草帽海賊團 = =\n");
            Console.WriteLine("姓名\t懸賞金額");
            Console.WriteLine("====================");

            // 陣列的 GetUpperBound(0) 方法可用來取某一維度的上限
            // 因此 RoleName.GetUpperBound(0) 會傳回 4
            for (int i = 0; i <= RoleName.GetUpperBound(0); i++)
            {
                // 顯示 RoleName[0]~RoleName[4] 及 Money[0]~Money[4]
                Console.WriteLine($"{RoleName[i]}\t{Money[i]:N0}");
            }

            Console.Read();
        }
    }
}
