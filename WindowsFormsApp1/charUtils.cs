using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 字符处理工具类
 * 用于处理字符串 16进制字符串 字节数组间的转换
 * 默认采用gb2312编码转换
 */
namespace PortAssistant
{
    class charUtils
    {
        /**
         * 字符串转字节数组
         */
        public static byte[] string2ByteArr(string content, string charset)
        {
            if ((content.Length % 2) != 0)
            {
                content += " ";//空格
            }
            System.Text.Encoding chs = System.Text.Encoding.GetEncoding(charset);
            return chs.GetBytes(content);
        }

        /**
         * 默认gb2312解码
         */
        public static byte[] string2ByteArr(string content)
        {
            return string2ByteArr(content, "gb2312");
        }

        /**
        * 字节数组转字符串
        */
        public static string byteArr2String(byte[] arr, string charset) {
            System.Text.Encoding chs = System.Text.Encoding.GetEncoding(charset);
            return chs.GetString(arr);
        }

        /**
         * 字节数组转字符串
         */
        public static string byteArr2String(byte[] arr) {
            System.Text.Encoding chs = System.Text.Encoding.GetEncoding("gb2312");
            return chs.GetString(arr);
        }


        /**
         * 字节数组转16进制字符串
         */
        public static string byteArr2Hex(byte[] arr)
        {
            StringBuilder HexContent = new StringBuilder();
            // 循环拼接 X 为16进制 2为位数
            foreach (byte temp in arr) {
                HexContent.Append(temp.ToString("X2") + " ");

            }
            return HexContent.ToString();
        }

        /**
         * 字符串转16进制
         * 默认为gb2312编码
         */
        public static string string2Hex(String Content) {
            return byteArr2Hex(string2ByteArr(Content, "gb2312"));
        }

        /**
         * 字符串转16进制
         * 需提供编码参数
         */
        public static string string2Hex(String Content, string charset)
        {
            return byteArr2Hex(string2ByteArr(Content, charset));
        }

        /**
         * 16进制字符转字节数组
         */
        public static byte[] hex2ByteArr(string HexContent) {
            // 防止16进制数组中的空格影响转换
            HexContent = HexContent.Replace(" ", "");
            if ((HexContent.Length % 2) != 0)
            {
                HexContent += " ";//空格
            }
            byte[] arr = new byte[HexContent.Length/2];
            // 两个16进制为一个字节
            for (int i = 0; i < arr.Length; i++)
            {
                // 第二个参数为保留16进制长度不丢失首位为0的字符
                arr[i] = byte.Parse(HexContent.Substring(i * 2, 2), System.Globalization.NumberStyles.HexNumber);
            }
            return arr;
        }

        /**
         * 16进制字符串转字符串
         * 默认为gb2312编码
         */
        public static string hex2String(string HexContent) {
            return byteArr2String(hex2ByteArr(HexContent), "gb2312") ;
        }

        /**
         * 16进制字符串转字符串
         * 自定义编码规格
         */
        public static string hex2String(string HexContent, string charset)
        {
            return byteArr2String(hex2ByteArr(HexContent), charset);
        }
    }
}
