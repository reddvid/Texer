﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texer.UWP.Helpers
{
    class Styles
    {
        public char[] alpha = new char[] {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
            '1', '2', '3', '4', '5', '6', '7', '8', '9', '0'
        };

        public string[] alphaShit = new string[] {
            "𝗔","𝗕","𝗖","𝗗","𝗘","𝗙","𝗚","𝗛","𝗜","𝗝","𝗞","𝗟","𝗠","𝗡","𝗢","𝗣","𝗤","𝗥","𝗦","𝗧","𝗨","𝗩","𝗪","𝗫","𝗬","𝗭",
            "𝗮","𝗯","𝗰","𝗱","𝗲","𝗳","𝗴","𝗵","𝗶","𝗷","𝗸","𝗹","𝗺","𝗻","𝗼","𝗽","𝗾","𝗿","𝘀","𝘁","𝘂","𝘃","𝘄","𝘅","𝘆","𝘇",
            "","𝟭","𝟮","𝟯","𝟰","𝟱","𝟲","𝟳","𝟴","𝟵","𝟬" };
        //<p>&#55349;&#56788;&#55349;&#56789;&#55349;&#56790;&#55349;&#56791;&#55349;&#56792;&#55349;&#56793;&#55349;&#56794;&#55349;&#56795;&#55349;&#56796;&#55349;&#56797;&#55349;&#56798;&#55349;&#56799;&#55349;&#56800;&#55349;&#56801;&#55349;&#56802;&#55349;&#56803;&#55349;&#56804;&#55349;&#56805;&#55349;&#56806;&#55349;&#56807;&#55349;&#56808;&#55349;&#56809;&#55349;&#56810;&#55349;&#56811;&#55349;&#56812;&#55349;&#56813;&#55349;&#56814;&#55349;&#56815;&#55349;&#56816;&#55349;&#56817;&#55349;&#56818;&#55349;&#56819;&#55349;&#56820;&#55349;&#56821;&#55349;&#56822;&#55349;&#56823;&#55349;&#56824;&#55349;&#56825;&#55349;&#56826;&#55349;&#56827;&#55349;&#56828;&#55349;&#56829;&#55349;&#56830;&#55349;&#56831;&#55349;&#56832;&#55349;&#56833;&#55349;&#56834;&#55349;&#56835;&#55349;&#56836;&#55349;&#56837;&#55349;&#56838;&#55349;&#56839;&#55349;&#57325;&#55349;&#57326;&#55349;&#57327;&#55349;&#57328;&#55349;&#57329;&#55349;&#57330;&#55349;&#57331;&#55349;&#57332;&#55349;&#57333;&#55349;&#57324;</p>
        //²³⁴⁵⁶⁷⁸⁹⁰
        //ａｂｃｄｅｆｇｈｉｊｋｌｍｎｏｐｑｒｓｔｕｖｗｘｙｚ
        //
        //ᵃᵇᶜᵈᵉᶠᵍʰᶦʲᵏᶫᵐᶰᵒᵖᑫʳˢᵗᵘᵛʷˣʸᶻ
        // 🄰🄱🄲🄳🄴🄵🄶🄷🄸🄹🄺🄻🄼🄽🄾🄿🅀🅁🅂🅃🅄🅅🅆🅇🅈🅉"
        // ⓐⓑⓒⓓⓔⓕⓖⓗⓘⓙⓚⓛⓜⓝⓞⓟⓠⓡⓢⓣⓤⓥⓦⓧⓨⓩ
        //ᴀʙᴄᴅᴇғɢʜɪᴊᴋʟᴍɴᴏᴘǫʀsᴛᴜᴠᴡxʏᴢ
        // ⒶⒷⒸⒹⒺⒻⒼⒽⒾⒿⓀⓁⓂⓃⓄⓅⓆⓇⓈⓉⓊⓋⓌⓍⓎⓏⓐⓑⓒⓓⓔⓕⓖⓗⓘⓙⓚⓛⓜⓝⓞⓟⓠⓡⓢⓣⓤⓥⓦⓧⓨⓩ①②③④⑤⑥⑦⑧⑨⓪
        //ＡＢＣＤＥＦＧＨＩＪＫＬＭＮＯＰＱＲＳＴＵＶＷＸＹＺａｂｃｄｅｆｇｈｉｊｋｌｍｎｏｐｑｒｓｔｕｖｗｘｙｚ１２３４５６７８９０
        public string[,] charArray = new string[,] {
            { "𝗔", "𝘈", "𝘼", "A̶", "𝒜", "ᵃ", "ᴀ", "🅐", "Ⓐ", "Ａ" },
            {"𝗕", "𝘉", "𝘽", "B̶", "ℬ", "ᵇ", "ʙ", "🅑", "Ⓑ", "Ｂ" },
            {"𝗖", "𝘊", "𝘾", "C̶", "𝒞", "ᶜ", "ᴄ", "🅒", "Ⓒ", "Ｃ" },
            {"𝗗", "𝘋", "𝘿", "D̶", "𝒟", "ᵈ", "ᴅ", "🅓", "Ⓓ", "Ｄ" },
            {"𝗘", "𝘌", "𝙀", "E̶", "ℰ", "ᵉ", "ᴇ", "🅔", "Ⓔ", "Ｅ" },
            {"𝗙", "𝘍", "𝙁", "F̶", "ℱ", "ᶠ", "ғ", "🅕", "Ⓕ", "Ｆ" },
            {"𝗚", "𝘎", "𝙂", "G̶", "𝒢", "ᵍ", "ɢ", "🅖", "Ⓖ", "Ｇ" },
            {"𝗛", "𝘏", "𝙃", "H̶", "ℋ", "ʰ", "ʜ", "🅗", "Ⓗ", "Ｈ" },
            {"𝗜", "𝘐", "𝙄", "I̶", "ℐ", "ᶦ", "ɪ", "🅘", "Ⓘ", "Ｉ" },
            {"𝗝", "𝘑", "𝙅", "J̶", "𝒥", "ʲ", "ᴊ", "🅙", "Ⓙ", "Ｊ" },
            {"𝗞", "𝘒", "𝙆", "K̶", "𝒦", "ᵏ", "ᴋ", "🅚", "Ⓚ", "Ｋ" },
            {"𝗟", "𝘓", "𝙇", "L̶", "ℒ", "ᶫ", "ʟ", "🅛", "Ⓛ", "Ｌ" },
            {"𝗠", "𝘔", "𝙈", "M̶", "ℳ", "ᵐ", "ᴍ", "🅜", "Ⓜ", "Ｍ" },
            {"𝗡", "𝘕", "𝙉", "N̶", "𝒩", "ᶰ", "ɴ", "🅝", "Ⓝ", "Ｎ" },
            {"𝗢", "𝘖", "𝙊", "O̶", "𝒪", "ᵒ", "ᴏ", "🅞", "Ⓞ", "Ｏ" },
            {"𝗣", "𝘗", "𝙋", "P̶", "𝒫", "ᵖ", "ᴘ", "🅟", "Ⓟ", "Ｐ" },
            {"𝗤", "𝘘", "𝙌", "Q̶", "𝒬", "ᑫ", "ǫ", "🅠", "Ⓠ", "Ｑ" },
            {"𝗥", "𝘙", "𝙍", "R̶", "ℛ", "ʳ", "ʀ", "🅡", "Ⓡ", "Ｒ" },
            {"𝗦", "𝘚", "𝙎", "S̶", "𝒮", "ˢ", "s", "🅢", "Ⓢ", "Ｓ" },
            {"𝗧", "𝘛", "𝙏", "T̶", "𝒯", "ᵗ", "ᴛ", "🅣", "Ⓣ", "Ｔ" },
            {"𝗨", "𝘜", "𝙐", "U̶", "𝒰", "ᵘ", "ᴜ", "🅤", "Ⓤ", "Ｕ" },
            {"𝗩", "𝘝", "𝙑", "V̶", "𝒱", "ᵛ", "ᴠ", "🅥", "Ⓥ", "Ｖ" },
            {"𝗪", "𝘞", "𝙒", "W̶", "𝒲", "ʷ", "ᴡ", "🅦", "Ⓦ", "Ｗ" },
            {"𝗫", "𝘟", "𝙓", "X̶", "𝒳", "ˣ", "x", "🅧", "Ⓧ", "Ｘ" },
            {"𝗬", "𝘠", "𝙔", "Y̶", "𝒴", "ʸ", "ʏ", "🅨", "Ⓨ", "Ｙ" },
            {"𝗭", "𝘡", "𝙕", "Z̶", "𝒵", "ᶻ", "ᴢ", "🅩", "Ⓩ", "Ｚ" },
            {"𝗮", "𝘢", "𝙖", "a̶", "𝒶", "ᵃ", "ᴀ", "🅐", "ⓐ", "ａ" },
            {"𝗯", "𝘣", "𝙗", "b̶", "𝒷", "ᵇ", "ʙ", "🅑", "ⓑ", "ｂ" },
            {"𝗰", "𝘤", "𝙘", "c̶", "𝒸", "ᶜ", "ᴄ", "🅒", "ⓒ", "ｃ" },
            {"𝗱", "𝘥", "𝙙", "d̶", "𝒹", "ᵈ", "ᴅ", "🅓", "ⓓ", "ｄ" },
            {"𝗲", "𝘦", "𝙚", "e̶", "ℯ", "ᵉ", "ᴇ", "🅔", "ⓔ", "ｅ" },
            {"𝗳", "𝘧", "𝙛", "f̶", "𝒻", "ᶠ", "ғ", "🅕", "ⓕ", "ｆ" },
            {"𝗴", "𝘨", "𝙜", "g̶", "ℊ", "ᵍ", "ɢ", "🅖", "ⓖ", "ｇ" },
            {"𝗵", "𝘩", "𝙝", "h̶", "𝒽", "ʰ", "ʜ", "🅗", "ⓗ", "ｈ" },
            {"𝗶", "𝘪", "𝙞", "i̶", "𝒾", "ᶦ", "ɪ", "🅘", "ⓘ", "ｉ" },
            {"𝗷", "𝘫", "𝙟", "j̶", "𝒿", "ʲ", "ᴊ", "🅙", "ⓙ", "ｊ" },
            {"𝗸", "𝘬", "𝙠", "k̶", "𝓀", "ᵏ", "ᴋ", "🅚", "ⓚ", "ｋ" },
            {"𝗹", "𝘭", "𝙡", "l̶", "𝓁", "ᶫ", "ʟ", "🅛", "ⓛ", "ｌ" },
            {"𝗺", "𝘮", "𝙢", "m̶", "𝓂", "ᵐ", "ᴍ", "🅜", "ⓜ", "ｍ" },
            {"𝗻", "𝘯", "𝙣", "n̶", "𝓃", "ᶰ", "ɴ", "🅝", "ⓝ", "ｎ" },
            {"𝗼", "𝘰", "𝙤", "o̶", "ℴ", "ᵒ", "ᴏ", "🅞", "ⓞ", "ｏ" },
            {"𝗽", "𝘱", "𝙥", "p̶", "𝓅", "ᵖ", "ᴘ", "🅟", "ⓟ", "ｐ" },
            {"𝗾", "𝘲", "𝙦", "q̶", "𝓆", "ᑫ", "ǫ", "🅠", "ⓠ", "ｑ" },
            {"𝗿", "𝘳", "𝙧", "r̶", "𝓇", "ʳ", "ʀ", "🅡", "ⓡ", "ｒ" },
            {"𝘀", "𝘴", "𝙨", "s̶", "𝓈", "ˢ", "s", "🅢", "ⓢ", "ｓ" },
            {"𝘁", "𝘵", "𝙩", "t̶", "𝓉", "ᵗ", "ᴛ", "🅣", "ⓣ", "ｔ" },
            {"𝘂", "𝘶", "𝙪", "u̶", "𝓊", "ᵘ", "ᴜ", "🅤", "ⓤ", "ｕ" },
            {"𝘃", "𝘷", "𝙫", "v̶", "𝓋", "ᵛ", "ᴠ", "🅥", "ⓥ", "ｖ" },
            {"𝘄", "𝘸", "𝙬", "w̶", "𝓌", "ʷ", "ᴡ", "🅦", "ⓦ", "ｗ" },
            {"𝘅", "𝘹", "𝙭", "x̶", "𝓍", "ˣ", "x", "🅧", "ⓧ", "ｘ" },
            {"𝘆", "𝘺", "𝙮", "y̶", "𝓎", "ʸ", "ʏ", "🅨", "ⓨ", "ｙ" },
            {"𝘇", "𝘻", "𝙯", "z̶", "𝓏", "ᶻ", "ᴢ", "🅩", "ⓩ", "ｚ" },
            {"𝟭", "1", "𝟭", "1̶", "1", "¹", "𝟷", "➊", "①", "１" },
            {"𝟮", "2", "𝟮", "2̶", "2", "²", "𝟸", "➋", "②", "２" },
            {"𝟯", "3", "𝟯", "3̶", "3", "³", "𝟹", "➌", "③", "３" },
            {"𝟰", "4", "𝟰", "4̶", "4", "⁴", "𝟺", "➍", "④", "４" },
            {"𝟱", "5", "𝟱", "5̶", "5", "⁵", "𝟻", "➎", "⑤", "５" },
            {"𝟲", "6", "𝟲", "6̶", "6", "⁶", "𝟼", "➏", "⑥", "６" },
            {"𝟳", "7", "𝟳", "7̶", "7", "⁷", "𝟽", "➐", "⑦", "７" },
            {"𝟴", "8", "𝟴", "8̶", "8", "⁸", "𝟾", "➑", "⑧", "８" },
            {"𝟵", "9", "𝟵", "9̶", "9", "⁹", "𝟿", "➒", "⑨", "９" },
            {"𝟬", "0", "𝟬", "0̶", "0", "⁰", "𝟶", "⓿", "⓪", "０" }
        };

    }
}
