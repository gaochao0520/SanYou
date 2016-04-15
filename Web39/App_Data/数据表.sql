if exists (select 1
            from  sysobjects
           where  id = object_id('TcAd')
            and   type = 'U')
   drop table TcAd
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TcAdmin')
            and   type = 'U')
   drop table TcAdmin
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TcArticle')
            and   type = 'U')
   drop table TcArticle
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TcChanpin')
            and   type = 'U')
   drop table TcChanpin
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TcConfig')
            and   type = 'U')
   drop table TcConfig
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TcDanye')
            and   type = 'U')
   drop table TcDanye
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TcFenlei')
            and   type = 'U')
   drop table TcFenlei
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TcHuandeng')
            and   type = 'U')
   drop table TcHuandeng
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TcKuozhan')
            and   type = 'U')
   drop table TcKuozhan
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TcLinks')
            and   type = 'U')
   drop table TcLinks
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TcLiuyan')
            and   type = 'U')
   drop table TcLiuyan
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TcQuxian')
            and   type = 'U')
   drop table TcQuxian
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TcSheng')
            and   type = 'U')
   drop table TcSheng
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TcShi')
            and   type = 'U')
   drop table TcShi
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TcTupian')
            and   type = 'U')
   drop table TcTupian
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TcZidian')
            and   type = 'U')
   drop table TcZidian
go

/*==============================================================*/
/* Table: TcAd                                                  */
/*==============================================================*/
create table TcAd (
   ID                   int                  identity,
   Title                nvarchar(200)        null,
   Types                int                  null,
   Kuan                 float                null,
   Gao                  float                null,
   Tupian               nvarchar(500)        null,
   Shuoming             ntext                null,
   Url                  nvarchar(500)        null,
   Code                 ntext                null,
   constraint PK_TCAD primary key (ID)
)
go

/*==============================================================*/
/* Table: TcAdmin                                               */
/*==============================================================*/
create table TcAdmin (
   ID                   int                  identity,
   Name                 varchar(100)         null,
   Pwd                  varchar(50)          null,
   Role                 int                  null,
   constraint PK_TCADMIN primary key (ID)
)
go

/*==============================================================*/
/* Table: TcArticle                                             */
/*==============================================================*/
create table TcArticle (
   ID                   int                  identity,
   Fenleiid             int                  null,
   Title                nvarchar(200)        null,
   Types                nvarchar(200)        null,
   Jianyao              nvarchar(200)        null,
   Tupian               nvarchar(200)        null,
   Shipin               nvarchar(500)        null,
   Url                  nvarchar(200)        null,
   Content              ntext                null,
   Click                int                  null,
   AddUser              int                  null,
   Addtime              datetime             null,
   Color                nvarchar(20)         null,
   IsTuijian            int                  null,
   IsTop                int                  null,
   SeoTitle             nvarchar(300)        null,
   SeoKeyword           nvarchar(300)        null,
   SeoDescription       nvarchar(300)        null,
   constraint PK_TCARTICLE primary key (ID)
)
go

/*==============================================================*/
/* Table: TcChanpin                                             */
/*==============================================================*/
create table TcChanpin (
   ID                   int                  identity,
   Articleid            int                  null,
   Shuxing              ntext                null,
   Addtime              datetime             null,
   constraint PK_TCCHANPIN primary key (ID)
)
go

/*==============================================================*/
/* Table: TcConfig                                              */
/*==============================================================*/
create table TcConfig (
   ID                   int                  identity,
   Ename                nvarchar(200)        null,
   Name                 nvarchar(200)        null,
   Types                nvarchar(50)         null,
   Content              ntext                null,
   constraint PK_TCCONFIG primary key (ID)
)
go

/*==============================================================*/
/* Table: TcDanye                                               */
/*==============================================================*/
create table TcDanye (
   ID                   int                  identity,
   Ename                nvarchar(200)        null,
   Types                nvarchar(200)        null,
   Name                 nvarchar(200)        null,
   Url                  nvarchar(200)        null,
   Tupian               nvarchar(200)        null,
   Fenlei               int                  null,
   Content              ntext                null,
   constraint PK_TCDANYE primary key (ID)
)
go

/*==============================================================*/
/* Table: TcFenlei                                              */
/*==============================================================*/
create table TcFenlei (
   ID                   int                  identity,
   Name                 nvarchar(50)         null,
   Types                nvarchar(50)         null,
   Pid                  int                  null,
   Paixu                int                  null,
   Url                  nvarchar(100)        null,
   Miaoshu              ntext                null,
   SeoTitle             nvarchar(300)        null,
   SeoKeyword           nvarchar(300)        null,
   SeoDescription       nvarchar(300)        null,
   constraint PK_TCFENLEI primary key (ID)
)
go

/*==============================================================*/
/* Table: TcHuandeng                                            */
/*==============================================================*/
create table TcHuandeng (
   ID                   int                  identity,
   Types                nvarchar(100)        null,
   Title                nvarchar(200)        null,
   Tupian               nvarchar(500)        null,
   Shuoming             text                 null,
   Url                  nvarchar(500)        null,
   Paixu                int                  null,
   constraint PK_TCHUANDENG primary key (ID)
)
go

/*==============================================================*/
/* Table: TcKuozhan                                             */
/*==============================================================*/
create table TcKuozhan (
   ID                   int                  identity,
   TabName              varchar(50)          null,
   Fid                  int                  null,
   Types                varchar(50)          null,
   Shuju                nvarchar(2000)       null,
   Addtime              datetime             null,
   constraint PK_TCKUOZHAN primary key (ID)
)
go

/*==============================================================*/
/* Table: TcLinks                                               */
/*==============================================================*/
create table TcLinks (
   ID                   int                  identity,
   Name                 nvarchar(200)        null,
   Types                nvarchar(200)        null,
   Url                  nvarchar(200)        null,
   LogoUrl              nvarchar(200)        null,
   Paixu                int                  null,
   IsXianshi            int                  null,
   Addtime              datetime             null,
   constraint PK_TCLINKS primary key (ID)
)
go

/*==============================================================*/
/* Table: TcLiuyan                                              */
/*==============================================================*/
create table TcLiuyan (
   ID                   int                  identity,
   Xingming             nvarchar(100)        null,
   QQ                   nvarchar(100)        null,
   GongsiMc             nvarchar(100)        null,
   Email                nvarchar(100)        null,
   Dianhua              nvarchar(100)        null,
   Dizhi                nvarchar(100)        null,
   Neirong              ntext                null,
   RukuSj               datetime             null,
   constraint PK_TCLIUYAN primary key (ID)
)
go

/*==============================================================*/
/* Table: TcQuxian                                              */
/*==============================================================*/
create table TcQuxian (
   ID                   int                  identity,
   Code                 char(6)              not null,
   Name                 varchar(50)          null,
   ShiCode              char(6)              null,
   Paixu                int                  null,
   constraint PK_TCQUXIAN primary key (ID)
)
go

/*==============================================================*/
/* Table: TcSheng                                               */
/*==============================================================*/
create table TcSheng (
   ID                   int                  identity,
   Code                 char(6)              not null,
   Name                 varchar(50)          null,
   Paixu                int                  null,
   constraint PK_TCSHENG primary key (ID)
)
go

/*==============================================================*/
/* Table: TcShi                                                 */
/*==============================================================*/
create table TcShi (
   ID                   int                  identity,
   Code                 char(6)              not null,
   Name                 varchar(50)          null,
   ShengCode            char(6)              null,
   Paixu                int                  null,
   constraint PK_TCSHI primary key (ID)
)
go

/*==============================================================*/
/* Table: TcTupian                                              */
/*==============================================================*/
create table TcTupian (
   ID                   int                  identity,
   Articleid            int                  null,
   Title                nvarchar(200)        null,
   Tupian               nvarchar(500)        null,
   Content              nvarchar(max)        null,
   Addtime              datetime             null,
   constraint PK_TCTUPIAN primary key (ID)
)
go

/*==============================================================*/
/* Table: TcZidian                                              */
/*==============================================================*/
create table TcZidian (
   ID                   int                  identity,
   Name                 nvarchar(100)        null,
   Types                nvarchar(50)         null,
   Paixu                int                  null,
   Pid                  int                  null,
   constraint PK_TCZIDIAN primary key (ID)
)
go
