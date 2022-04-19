/* 数据类型 -- 基本类型
 * 8 种, 整数类型
 * 2 种, 浮点型 (用于科学计算)
 * 1 种, 浮点型 (用于金融计算)
 * 1 种, 布尔型
 * 1 种, 字符型
 *
 * 数据类型 -- 复合类型
 *
 * 整型
 * - int 32bit
 * - long 64bit
 *
 * 浮点
 * - float
 * - double 有效数字 15 ~ 16
 * - decimal 金融计算涉及到金额的.
 *
 * 字面值:
 * 如果没有声明数字的数据类型, 默认整数用 int , 小数用 double
 *
 * 指数写法 字面量
 */

using System;

//使用名为 System 的命名空间.


namespace Lesson_2_DataType
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var num = 1.123456789123456789;
            Console.WriteLine(num);

            //指数形式
            var a = 2E10; // E = * 10^n 
            Console.WriteLine(a);
        }
    }
}