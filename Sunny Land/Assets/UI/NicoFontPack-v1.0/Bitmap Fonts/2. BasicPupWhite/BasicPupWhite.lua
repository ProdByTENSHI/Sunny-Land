local Font = {}

Font.info = 
    {
    face              = "NicoPups",
    file              = "BasicPupWhite.png",
    size              = 16,
    bold              = 0,
    italic            = 0,
    charset           = "",
    unicode           = 0,
    stretchH          = 100,
    smooth            = 1,
    aa                = 1,
    padding           = {0, 0, 0, 0},
    spacing           = 2,
    charsCount        = 95,
    kerningsCounts    = 0,
    }

Font.common =
    {
    lineHeight        = 16,
    base              = 13,
    scaleW            = 100,
    scaleH            = 145,
    pages             = 1,
    packed            = 0,
    }

Font.chars =
    {
    {id=32,x=37,y=134,width=0,height=0,xoffset=0,yoffset=12,xadvance=5,page=0,chnl=0,letter="space"},
    {id=33,x=31,y=99,width=4,height=11,xoffset=1,yoffset=2,xadvance=3,page=0,chnl=0,letter="!"},
    {id=34,x=74,y=123,width=6,height=6,xoffset=1,yoffset=2,xadvance=5,page=0,chnl=0,letter=string.char(34)},
    {id=35,x=38,y=33,width=11,height=11,xoffset=0,yoffset=2,xadvance=9,page=0,chnl=0,letter="#"},
    {id=36,x=77,y=2,width=8,height=13,xoffset=1,yoffset=1,xadvance=7,page=0,chnl=0,letter="$"},
    {id=37,x=24,y=33,width=12,height=11,xoffset=1,yoffset=2,xadvance=11,page=0,chnl=0,letter="%"},
    {id=38,x=51,y=33,width=11,height=11,xoffset=1,yoffset=2,xadvance=10,page=0,chnl=0,letter="&"},
    {id=39,x=82,y=123,width=4,height=6,xoffset=1,yoffset=2,xadvance=3,page=0,chnl=0,letter="'"},
    {id=40,x=41,y=2,width=5,height=14,xoffset=1,yoffset=1,xadvance=4,page=0,chnl=0,letter="("},
    {id=41,x=48,y=2,width=5,height=14,xoffset=1,yoffset=1,xadvance=4,page=0,chnl=0,letter=")"},
    {id=42,x=31,y=123,width=8,height=8,xoffset=0,yoffset=1,xadvance=6,page=0,chnl=0,letter="*"},
    {id=43,x=41,y=123,width=8,height=8,xoffset=1,yoffset=4,xadvance=7,page=0,chnl=0,letter="+"},
    {id=44,x=57,y=123,width=5,height=7,xoffset=2,yoffset=8,xadvance=5,page=0,chnl=0,letter=","},
    {id=45,x=27,y=134,width=8,height=4,xoffset=1,yoffset=6,xadvance=7,page=0,chnl=0,letter="-"},
    {id=46,x=2,y=134,width=5,height=5,xoffset=1,yoffset=8,xadvance=4,page=0,chnl=0,letter="."},
    {id=47,x=55,y=2,width=9,height=13,xoffset=0,yoffset=2,xadvance=7,page=0,chnl=0,letter="/"},
    {id=48,x=24,y=73,width=8,height=11,xoffset=1,yoffset=2,xadvance=7,page=0,chnl=0,letter="0"},
    {id=49,x=34,y=73,width=8,height=11,xoffset=1,yoffset=2,xadvance=7,page=0,chnl=0,letter="1"},
    {id=50,x=44,y=73,width=8,height=11,xoffset=1,yoffset=2,xadvance=7,page=0,chnl=0,letter="2"},
    {id=51,x=54,y=73,width=8,height=11,xoffset=1,yoffset=2,xadvance=7,page=0,chnl=0,letter="3"},
    {id=52,x=14,y=60,width=9,height=11,xoffset=0,yoffset=2,xadvance=7,page=0,chnl=0,letter="4"},
    {id=53,x=64,y=73,width=8,height=11,xoffset=1,yoffset=2,xadvance=7,page=0,chnl=0,letter="5"},
    {id=54,x=25,y=60,width=9,height=11,xoffset=1,yoffset=2,xadvance=8,page=0,chnl=0,letter="6"},
    {id=55,x=74,y=73,width=8,height=11,xoffset=1,yoffset=2,xadvance=7,page=0,chnl=0,letter="7"},
    {id=56,x=84,y=73,width=8,height=11,xoffset=1,yoffset=2,xadvance=7,page=0,chnl=0,letter="8"},
    {id=57,x=2,y=86,width=8,height=11,xoffset=1,yoffset=2,xadvance=7,page=0,chnl=0,letter="9"},
    {id=58,x=51,y=123,width=4,height=8,xoffset=1,yoffset=4,xadvance=3,page=0,chnl=0,letter=":"},
    {id=59,x=65,y=99,width=5,height=10,xoffset=1,yoffset=5,xadvance=4,page=0,chnl=0,letter=";"},
    {id=60,x=43,y=99,width=9,height=10,xoffset=1,yoffset=3,xadvance=8,page=0,chnl=0,letter="<"},
    {id=61,x=64,y=123,width=8,height=6,xoffset=1,yoffset=5,xadvance=7,page=0,chnl=0,letter="="},
    {id=62,x=54,y=99,width=9,height=10,xoffset=1,yoffset=3,xadvance=8,page=0,chnl=0,letter=">"},
    {id=63,x=22,y=99,width=7,height=11,xoffset=1,yoffset=2,xadvance=6,page=0,chnl=0,letter="?"},
    {id=64,x=2,y=19,width=12,height=12,xoffset=1,yoffset=2,xadvance=11,page=0,chnl=0,letter="@"},
    {id=65,x=36,y=60,width=9,height=11,xoffset=0,yoffset=2,xadvance=7,page=0,chnl=0,letter="A"},
    {id=66,x=47,y=60,width=9,height=11,xoffset=0,yoffset=2,xadvance=7,page=0,chnl=0,letter="B"},
    {id=67,x=2,y=47,width=10,height=11,xoffset=0,yoffset=2,xadvance=8,page=0,chnl=0,letter="C"},
    {id=68,x=14,y=47,width=10,height=11,xoffset=0,yoffset=2,xadvance=8,page=0,chnl=0,letter="D"},
    {id=69,x=12,y=86,width=8,height=11,xoffset=1,yoffset=2,xadvance=7,page=0,chnl=0,letter="E"},
    {id=70,x=22,y=86,width=8,height=11,xoffset=1,yoffset=2,xadvance=7,page=0,chnl=0,letter="F"},
    {id=71,x=26,y=47,width=10,height=11,xoffset=0,yoffset=2,xadvance=8,page=0,chnl=0,letter="G"},
    {id=72,x=58,y=60,width=9,height=11,xoffset=0,yoffset=2,xadvance=7,page=0,chnl=0,letter="H"},
    {id=73,x=32,y=86,width=8,height=11,xoffset=1,yoffset=2,xadvance=7,page=0,chnl=0,letter="I"},
    {id=74,x=42,y=86,width=8,height=11,xoffset=1,yoffset=2,xadvance=7,page=0,chnl=0,letter="J"},
    {id=75,x=69,y=60,width=9,height=11,xoffset=1,yoffset=2,xadvance=8,page=0,chnl=0,letter="K"},
    {id=76,x=52,y=86,width=8,height=11,xoffset=1,yoffset=2,xadvance=7,page=0,chnl=0,letter="L"},
    {id=77,x=38,y=47,width=10,height=11,xoffset=0,yoffset=2,xadvance=8,page=0,chnl=0,letter="M"},
    {id=78,x=50,y=47,width=10,height=11,xoffset=0,yoffset=2,xadvance=8,page=0,chnl=0,letter="N"},
    {id=79,x=64,y=33,width=11,height=11,xoffset=0,yoffset=2,xadvance=9,page=0,chnl=0,letter="O"},
    {id=80,x=62,y=86,width=8,height=11,xoffset=1,yoffset=2,xadvance=7,page=0,chnl=0,letter="P"},
    {id=81,x=77,y=33,width=11,height=11,xoffset=0,yoffset=2,xadvance=9,page=0,chnl=0,letter="Q"},
    {id=82,x=80,y=60,width=9,height=11,xoffset=1,yoffset=2,xadvance=8,page=0,chnl=0,letter="R"},
    {id=83,x=72,y=86,width=8,height=11,xoffset=1,yoffset=2,xadvance=7,page=0,chnl=0,letter="S"},
    {id=84,x=82,y=86,width=8,height=11,xoffset=1,yoffset=2,xadvance=7,page=0,chnl=0,letter="T"},
    {id=85,x=2,y=73,width=9,height=11,xoffset=0,yoffset=2,xadvance=7,page=0,chnl=0,letter="U"},
    {id=86,x=62,y=47,width=10,height=11,xoffset=0,yoffset=2,xadvance=8,page=0,chnl=0,letter="V"},
    {id=87,x=74,y=47,width=10,height=11,xoffset=0,yoffset=2,xadvance=8,page=0,chnl=0,letter="W"},
    {id=88,x=86,y=47,width=10,height=11,xoffset=0,yoffset=2,xadvance=8,page=0,chnl=0,letter="X"},
    {id=89,x=2,y=60,width=10,height=11,xoffset=0,yoffset=2,xadvance=8,page=0,chnl=0,letter="Y"},
    {id=90,x=13,y=73,width=9,height=11,xoffset=0,yoffset=2,xadvance=7,page=0,chnl=0,letter="Z"},
    {id=91,x=26,y=2,width=5,height=15,xoffset=1,yoffset=1,xadvance=4,page=0,chnl=0,letter="["},
    {id=92,x=66,y=2,width=9,height=13,xoffset=0,yoffset=2,xadvance=7,page=0,chnl=0,letter=string.char(92)},
    {id=93,x=2,y=2,width=6,height=15,xoffset=0,yoffset=1,xadvance=4,page=0,chnl=0,letter="]"},
    {id=94,x=2,y=112,width=9,height=9,xoffset=1,yoffset=2,xadvance=8,page=0,chnl=0,letter="^"},
    {id=95,x=16,y=134,width=9,height=4,xoffset=1,yoffset=10,xadvance=8,page=0,chnl=0,letter="_"},
    {id=96,x=9,y=134,width=5,height=5,xoffset=0,yoffset=1,xadvance=3,page=0,chnl=0,letter="`"},
    {id=97,x=24,y=112,width=8,height=9,xoffset=1,yoffset=4,xadvance=7,page=0,chnl=0,letter="a"},
    {id=98,x=28,y=19,width=9,height=12,xoffset=1,yoffset=1,xadvance=8,page=0,chnl=0,letter="b"},
    {id=99,x=34,y=112,width=8,height=9,xoffset=1,yoffset=4,xadvance=7,page=0,chnl=0,letter="c"},
    {id=100,x=61,y=19,width=8,height=12,xoffset=1,yoffset=1,xadvance=7,page=0,chnl=0,letter="d"},
    {id=101,x=44,y=112,width=8,height=9,xoffset=1,yoffset=4,xadvance=7,page=0,chnl=0,letter="e"},
    {id=102,x=2,y=99,width=8,height=11,xoffset=1,yoffset=2,xadvance=7,page=0,chnl=0,letter="f"},
    {id=103,x=71,y=19,width=8,height=12,xoffset=1,yoffset=4,xadvance=7,page=0,chnl=0,letter="g"},
    {id=104,x=81,y=19,width=8,height=12,xoffset=1,yoffset=1,xadvance=7,page=0,chnl=0,letter="h"},
    {id=105,x=37,y=99,width=4,height=11,xoffset=1,yoffset=2,xadvance=3,page=0,chnl=0,letter="i"},
    {id=106,x=33,y=2,width=6,height=14,xoffset=1,yoffset=2,xadvance=5,page=0,chnl=0,letter="j"},
    {id=107,x=2,y=33,width=8,height=12,xoffset=1,yoffset=1,xadvance=7,page=0,chnl=0,letter="k"},
    {id=108,x=12,y=33,width=4,height=12,xoffset=1,yoffset=1,xadvance=3,page=0,chnl=0,letter="l"},
    {id=109,x=86,y=99,width=11,height=9,xoffset=1,yoffset=4,xadvance=10,page=0,chnl=0,letter="m"},
    {id=110,x=54,y=112,width=8,height=9,xoffset=1,yoffset=4,xadvance=7,page=0,chnl=0,letter="n"},
    {id=111,x=64,y=112,width=8,height=9,xoffset=1,yoffset=4,xadvance=7,page=0,chnl=0,letter="o"},
    {id=112,x=39,y=19,width=9,height=12,xoffset=1,yoffset=4,xadvance=8,page=0,chnl=0,letter="p"},
    {id=113,x=16,y=19,width=10,height=12,xoffset=1,yoffset=4,xadvance=9,page=0,chnl=0,letter="q"},
    {id=114,x=74,y=112,width=8,height=9,xoffset=1,yoffset=4,xadvance=7,page=0,chnl=0,letter="r"},
    {id=115,x=22,y=123,width=7,height=9,xoffset=1,yoffset=4,xadvance=6,page=0,chnl=0,letter="s"},
    {id=116,x=12,y=99,width=8,height=11,xoffset=0,yoffset=2,xadvance=6,page=0,chnl=0,letter="t"},
    {id=117,x=84,y=112,width=8,height=9,xoffset=1,yoffset=4,xadvance=7,page=0,chnl=0,letter="u"},
    {id=118,x=2,y=123,width=8,height=9,xoffset=1,yoffset=4,xadvance=7,page=0,chnl=0,letter="v"},
    {id=119,x=72,y=99,width=12,height=9,xoffset=0,yoffset=4,xadvance=10,page=0,chnl=0,letter="w"},
    {id=120,x=13,y=112,width=9,height=9,xoffset=0,yoffset=4,xadvance=7,page=0,chnl=0,letter="x"},
    {id=121,x=50,y=19,width=9,height=12,xoffset=0,yoffset=4,xadvance=7,page=0,chnl=0,letter="y"},
    {id=122,x=12,y=123,width=8,height=9,xoffset=1,yoffset=4,xadvance=7,page=0,chnl=0,letter="z"},
    {id=123,x=10,y=2,width=6,height=15,xoffset=0,yoffset=1,xadvance=4,page=0,chnl=0,letter="{"},
    {id=124,x=18,y=33,width=4,height=12,xoffset=1,yoffset=2,xadvance=3,page=0,chnl=0,letter="|"},
    {id=125,x=18,y=2,width=6,height=15,xoffset=0,yoffset=1,xadvance=4,page=0,chnl=0,letter="}"},
    {id=126,x=88,y=123,width=9,height=5,xoffset=1,yoffset=6,xadvance=8,page=0,chnl=0,letter="~"},
    }

Font.kerning =
    {
    }

return Font