// 第一个程序
// 输出一句话
// 注意中英文符号差异
// 编译: SDK compile cs 文件
// 运行: run cs 文件
// Main()函数, 是约定俗成的程序入口


using System;

namespace Lesson_1_Introduction
{
    internal class HelloWorld
    {
        //每个大括号之间算一个代码块
        private static void Main()
        {
            // string 字符串: 数据类型
            // message 变量
            // 变量的作用域: 这是个局部变量, 只能在当前代码块中使用. 
            string message; // 变量的声明
            message = "This is the Hello World !"; // 变量的赋值

            // 空白是指程序中的table,空格,回车. 是不会纳入编译运行的过程的.
            // 单行代码: 不影响程序编译和运行, 但是不易于阅读. 所以不建议用单行.
            Console.WriteLine(message); // 语句结束用分号结束

            string message1, message2; // 一条语句声明两个变量
            message1 = "This is the first message !!";
            message2 = "This is the second message !!";
            Console.WriteLine(message1); // 语句结束用分号结束
            Console.WriteLine(message2); // 语句结束用分号结束

            // 变量命名规范
            // 1. 字母或下划线开头
            // 2. 后跟任意数量字母,数字,下划线
            // 变量习惯上用 camel 大小写形式
            // 注意: 数字不能开头
            // camel 驼峰大小写: 变量上习惯开头小写字母, 后面每个单词首字母大写.

            // 变量的赋值
            // 使用赋值符号 '=', 自右向左赋值.

            string str1, str2 = "qwe"; // 声明的同时可以直接赋值
            str1 = str2 = "iuy"; // 这是多次赋值
            str1 = "abc";
            Console.WriteLine(str1); // 语句结束用分号结束

            str1 = "123";
            Console.WriteLine(str1); // 语句结束用分号结束

            // 这是控制台输出
            Console.WriteLine(str2); // 语句结束用分号结束

            // 控制台输入
            str2 = Console.ReadLine();
            // 然后输出
            Console.WriteLine(str2); // 语句结束用分号结束

            Console.WriteLine("你的名字是: "); // 语句结束用分号结束
            var name = Console.ReadLine();
            Console.WriteLine("我的名字是: " + name);
            Console.WriteLine("我的名字是: {0}", name);
            // {0} 表示后面 0 位的变量, 优势是可以颠倒位置 {1}{0}. 
            Console.WriteLine("我的名字是: {0}{1}", name, str2);
            Console.WriteLine("我的名字是: {1}{0}", name, str2);

            // 注释: 
            // 行注释
            /* 块注释 */
            /**
         * XML 注释
         */
        }
    }
}