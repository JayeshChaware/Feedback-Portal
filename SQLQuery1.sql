create table tblFeedbacks(
PK_ID int not null,
FK_tblFeedBacks_tblProducts int not null,
FK_tblFeedBacks_tblUsers int not null,
Rating int not null,
Comment varchar ,
Warning int default 0,
FeedbackDate date not null,
primary key(PK_ID),
foreign key (FK_tblFeedBacks_tblProducts) references tblProducts(PK_ID),
foreign key (FK_tblFeedBacks_tblUsers) references tblUsers(PK_ID)
);

create table tblQuestions(
PK_ID int not null,
FK_tblQuestions_tblProducts int not null,
FK_tblQuestions_tblUsers int not null,
Question varchar not null,
Warning int default 0,
QuestionDate date not null,
primary key(PK_ID),
foreign key (FK_tblQuestions_tblProducts) references tblProducts(PK_ID),
foreign key (FK_tblQuestions_tblUsers) references tblUsers(PK_ID)
);

create table tblAnswers(
PK_ID int not null,
FK_tblAnswers_tblProducts int not null,
FK_tblAnswers_tblUsers int not null,
FK_tblAnswers_tblQuestions int not null,
Question varchar not null,
Warning int default 0,
QuestionDate date not null,
primary key(PK_ID),
foreign key (FK_tblAnswers_tblProducts) references tblProducts(PK_ID),
foreign key (FK_tblAnswers_tblUsers) references tblUsers(PK_ID),
foreign key (FK_tblAnswers_tblQuestions) references tblQuestions(PK_ID)
);