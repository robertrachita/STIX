USE Netflix

-- SUBSCRIPTION INSERT
INSERT INTO Subscription(subscription_name, price) values ('Single', 7.99)
INSERT INTO Subscription(subscription_name, price) values ( 'Basic', 10.99)
INSERT INTO Subscription(subscription_name, price) values ( 'Premium', 13.99)

--QUALITY INSERT
insert into Quality ( quality_name) values ('SD');
insert into Quality ( quality_name) values ('HD');
insert into Quality ( quality_name) values ('UHD');

--SUBSCRIPTION QUALITY INSERT
insert into SubscriptionQuality (quality_id, subscription_id) values (1, 1);
insert into SubscriptionQuality (quality_id, subscription_id) values (2, 2);
insert into SubscriptionQuality (quality_id, subscription_id) values (3, 2);
insert into SubscriptionQuality (quality_id, subscription_id) values (1, 2);
insert into SubscriptionQuality (quality_id, subscription_id) values (2, 3);

--LANGUAGE INSERT
insert into Language (language_name) values ('Norwegian');
insert into Language (language_name) values ('Bosnian');
insert into Language (language_name) values ('Gujarati');
insert into Language (language_name) values ('Kyrgyz');
insert into Language (language_name) values ('Tsonga');
insert into Language (language_name) values ('Kurdish');
insert into Language (language_name) values ('Telugu');
insert into Language (language_name) values ('Ndebele');
insert into Language (language_name) values ('Dhivehi');
insert into Language (language_name) values ('Luxembourgish');
insert into Language (language_name) values ('French');
insert into Language (language_name) values ('Kurdish');
insert into Language (language_name) values ('Somali');
insert into Language (language_name) values ('Tsonga');
insert into Language (language_name) values ('Bengali');
insert into Language (language_name) values ('Malay');
insert into Language (language_name) values ('Thai');
insert into Language (language_name) values ('Greek');
insert into Language (language_name) values ('Haitian Creole');
insert into Language (language_name) values ('Malayalam');
insert into Language (language_name) values ('Polish');
insert into Language (language_name) values ('Khmer');
insert into Language (language_name) values ('Norwegian');
insert into Language (language_name) values ('Gujarati');
insert into Language (language_name) values ('Macedonian');
insert into Language (language_name) values ('Croatian');
insert into Language (language_name) values ('Spanish');
insert into Language (language_name) values ('Amharic');
insert into Language (language_name) values ('Kurdish');
insert into Language (language_name) values ('Quechua');
insert into Language (language_name) values ('Dutch');
insert into Language (language_name) values ('English');


--CINEMA (Movie/Series) INSERT
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Werewolf Boy, A (Neuk-dae-so-nyeon)', 'Flour - Buckwheat, Dark', '01:22:12', 'Macejkovic Inc');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Eat a Bowl of Tea', 'Brandy Cherry - Mcguinness', '01:22:12', 'Howe-Veum');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Days and Clouds (Giorni e nuvole)', 'Carbonated Water - Peach', '01:22:12', 'Lebsack, Nader and Goldner');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('My Future Boyfriend', 'Soup - Tomato Mush. Florentine', '01:22:12', 'Gleichner Inc');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Dark Wind, The', 'Truffle Cups - Red', '01:22:12', 'Gorczany-Wilkinson');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Detachment', 'Tart - Lemon', '01:22:12', 'Lesch, Lowe and Swaniawski');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Rickshaw Man, The (Muhomatsu no issho)', 'Soup - Campbells, Butternut', '01:22:12', 'Hilll, Hansen and Kulas');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Thirty-Nine Steps, The', 'Bagel - 12 Grain Preslice', '01:22:12', 'McGlynn-Emmerich');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Claymation Christmas Celebration, A', 'Yoghurt Tubes', '01:22:12', 'McKenzie-Crona');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('It Runs in the Family', 'Pineapple - Regular', '01:22:12', 'Marvin and Sons');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Mosquito Coast, The', 'Otomegusa Dashi Konbu', '01:22:12', 'Lockman LLC');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('ABBA: The Movie', 'Browning Caramel Glace', '01:22:12', 'Donnelly-Bins');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Lake, A (Un lac)', 'Butter - Pod', '01:22:12', 'Swaniawski Group');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Severe Clear', 'Lettuce - Green Leaf', '01:22:12', 'Feil, Fadel and Bogisich');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Aspen', 'Wine - Magnotta - Red, Baco', '01:22:12', 'Harvey-Hickle');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Computer Chess', 'Napkin Colour', '01:22:12', 'Sawayn-Stiedemann');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Trilogy of Terror II', 'Cookie Dough - Double', '01:22:12', 'Halvorson-Runte');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Time Lapse', 'Sauce Bbq Smokey', '01:22:12', 'Corwin, Miller and Mraz');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Sister My Sister', 'Garam Marsala', '01:22:12', 'Bradtke-Keebler');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Fly, The', 'Mushroom - Shitake, Dry', '01:22:12', 'Gerlach-Reynolds');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Mallrats', 'Shortbread - Cookie Crumbs', '01:22:12', 'Mraz, Heidenreich and Gulgowski');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('No Blade of Grass', 'Lamb - Racks, Frenched', '01:22:12', 'Hackett-Christiansen');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('I''m the One That I Want', 'Emulsifier', '01:22:12', 'Dietrich Inc');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Massacre Canyon', 'Soup - Campbells, Classic Chix', '01:22:12', 'Nikolaus, Mante and Pollich');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('A Flintstones Christmas Carol', 'Pepper - Cubanelle', '01:22:12', 'Murazik LLC');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Redhead from Wyoming, The', 'Pastry - Cheese Baked Scones', '01:22:12', 'Feest, Hessel and West');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Ninja', 'Irish Cream - Baileys', '01:22:12', 'Jacobs, Ernser and Mante');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Swordsman II (Legend of the Swordsman, The) (Xiao ao jiang hu zhi: Dong Fang Bu Bai)', 'Wine - Puligny Montrachet A.', '01:22:12', 'Olson-Beatty');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Voodoo Tiger', 'Mushroom - White Button', '01:22:12', 'Bruen LLC');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Age of Stupid, The', 'Tomatoes - Hot House', '01:22:12', 'Deckow, Pfannerstill and Beahan');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Ballad of Ramblin'' Jack, The', 'Vinegar - Tarragon', '01:22:12', 'Jenkins and Sons');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Nightmare on Elm Street 4: The Dream Master, A', 'Parsley Italian - Fresh', '01:22:12', 'Johnston LLC');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Acla, The Descent into Floristella (La discesa di Aclà a Floristella)', 'Pepper - Black, Crushed', '01:22:12', 'Klocko-Abshire');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Dracula 2000', 'Calypso - Black Cherry Lemonade', '01:22:12', 'Legros and Sons');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Going All the Way', 'Extract Vanilla Pure', '01:22:12', 'Kiehn, Terry and Emmerich');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Pressure Point ', 'Gingerale - Schweppes, 355 Ml', '01:22:12', 'Beatty, Moen and Hand');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Pride and Glory', 'Tea - Orange Pekoe', '01:22:12', 'Von-Stamm');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Roaring Twenties, The', 'Rum - White, Gg White', '01:22:12', 'Shields-Weimann');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Bloody Child, The', 'Chickhen - Chicken Phyllo', '01:22:12', 'O''Hara and Sons');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Starry Eyes', 'Soho Lychee Liqueur', '01:22:12', 'Romaguera, Jaskolski and Kuphal');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Once in a Lifetime', 'Crackers - Graham', '01:22:12', 'Zieme Inc');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Heaven Help Us', 'Shiro Miso', '01:22:12', 'Windler, O''Hara and Smith');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Alyce Kills', 'Longos - Assorted Sandwich', '01:22:12', 'Lang and Sons');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Five Minarets in New York (Act of Vengeance) (Terrorist, The)', 'Macaroons - Two Bite Choc', '01:22:12', 'Williamson-Will');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Bronx Tale, A', 'Clam Nectar', '01:22:12', 'Nikolaus-Hettinger');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Stratton Story, The', 'Pesto - Primerba, Paste', '01:22:12', 'Abbott, Weissnat and Daniel');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('We Live in Public', 'Tarts Assorted', '01:22:12', 'Wyman-Howe');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Roxanne', 'Turkey - Ground. Lean', '01:22:12', 'Gusikowski, Senger and Mitchell');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Company You Keep, The', 'Bread - Raisin Walnut Oval', '01:22:12', 'Klein, Bins and Roob');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Pretty Bird', 'Soup - Base Broth Beef', '01:22:12', 'Kunze, Waters and Goldner');
insert into Cinema (cinema_name, cinema_description, duration, credits) values ('Stenden', 'Soup - Base Broth Beef', '01:12:12', 'Kunze');

--CINEMA QUALITY 
insert into CinemaQuality (cinema_id, quality_id) values ('29', 1);
insert into CinemaQuality (cinema_id, quality_id) values ('30', 3);
insert into CinemaQuality (cinema_id, quality_id) values ('12', 3);
insert into CinemaQuality (cinema_id, quality_id) values ('1', 1);
insert into CinemaQuality (cinema_id, quality_id) values ('37', 2);
insert into CinemaQuality (cinema_id, quality_id) values ('43', 3);
insert into CinemaQuality (cinema_id, quality_id) values ('26', 1);
insert into CinemaQuality (cinema_id, quality_id) values ('27', 2);
insert into CinemaQuality (cinema_id, quality_id) values ('34', 3);
insert into CinemaQuality (cinema_id, quality_id) values ('35', 3);
insert into CinemaQuality (cinema_id, quality_id) values ('13', 3);
insert into CinemaQuality (cinema_id, quality_id) values ('47', 3);
insert into CinemaQuality (cinema_id, quality_id) values ('24', 3);
insert into CinemaQuality (cinema_id, quality_id) values ('20', 1);
insert into CinemaQuality (cinema_id, quality_id) values ('41', 2);
insert into CinemaQuality (cinema_id, quality_id) values ('48', 2);
insert into CinemaQuality (cinema_id, quality_id) values ('21', 1);
insert into CinemaQuality (cinema_id, quality_id) values ('7', 3);
insert into CinemaQuality (cinema_id, quality_id) values ('10', 2);
insert into CinemaQuality (cinema_id, quality_id) values ('32', 1);

--GENRE INSERT
insert into Genre (genre_name) values ('Sci-Fi');
insert into Genre (genre_name) values ('Anime');
insert into Genre (genre_name) values ('Horror');
insert into Genre (genre_name) values ('Action');
insert into Genre (genre_name) values ('Musical');
insert into Genre (genre_name) values ('Romantic Comedy');
insert into Genre (genre_name) values ('Drama');
insert into Genre (genre_name) values ('Children|Drama');
insert into Genre (genre_name) values ('Adventure|Children|Drama|Fantasy');
insert into Genre (genre_name) values ('Drama|War');
insert into Genre (genre_name) values ('Drama|Romance|War');
insert into Genre (genre_name) values ('Action|Adventure|Sci-Fi|Thriller');
insert into Genre (genre_name) values ('Documentary');
insert into Genre (genre_name) values ('Crime|Drama');
insert into Genre (genre_name) values ('Drama');
insert into Genre (genre_name) values ('Adventure|Children|Comedy');
insert into Genre (genre_name) values ('Children|Crime|Drama');
insert into Genre (genre_name) values ('Adventure|Romance|War');
insert into Genre (genre_name) values ('Adventure|Children|Drama');
insert into Genre (genre_name) values ('Documentary');

--CINEMA GENRE INSERT
insert into CinemaGenre (cinema_id, genre_id) values ('1', 1);
insert into CinemaGenre (cinema_id, genre_id) values ('2', 4);
insert into CinemaGenre (cinema_id, genre_id) values ('3', 3);
insert into CinemaGenre (cinema_id, genre_id) values ('4', 2);
insert into CinemaGenre (cinema_id, genre_id) values ('5', 5);
insert into CinemaGenre (cinema_id, genre_id) values ('6', 15);
insert into CinemaGenre (cinema_id, genre_id) values ('7', 7);
insert into CinemaGenre (cinema_id, genre_id) values ('8', 7);
insert into CinemaGenre (cinema_id, genre_id) values ('9', 19);
insert into CinemaGenre (cinema_id, genre_id) values ('10', 3);
insert into CinemaGenre (cinema_id, genre_id) values ('11', 19);
insert into CinemaGenre (cinema_id, genre_id) values ('12', 9);
insert into CinemaGenre (cinema_id, genre_id) values ('13', 12);
insert into CinemaGenre (cinema_id, genre_id) values ('14', 12);
insert into CinemaGenre (cinema_id, genre_id) values ('15', 5);
insert into CinemaGenre (cinema_id, genre_id) values ('16', 8);
insert into CinemaGenre (cinema_id, genre_id) values ('17', 13);
insert into CinemaGenre (cinema_id, genre_id) values ('18', 15);
insert into CinemaGenre (cinema_id, genre_id) values ('19', 14);
insert into CinemaGenre (cinema_id, genre_id) values ('20', 9);
insert into CinemaGenre (cinema_id, genre_id) values ('21', 16);
insert into CinemaGenre (cinema_id, genre_id) values ('22', 13);
insert into CinemaGenre (cinema_id, genre_id) values ('23', 20);
insert into CinemaGenre (cinema_id, genre_id) values ('24', 13);
insert into CinemaGenre (cinema_id, genre_id) values ('25', 16);
insert into CinemaGenre (cinema_id, genre_id) values ('26', 13);
insert into CinemaGenre (cinema_id, genre_id) values ('27', 20);
insert into CinemaGenre (cinema_id, genre_id) values ('28', 9);
insert into CinemaGenre (cinema_id, genre_id) values ('29', 17);
insert into CinemaGenre (cinema_id, genre_id) values ('30', 15);
insert into CinemaGenre (cinema_id, genre_id) values ('31', 19);
insert into CinemaGenre (cinema_id, genre_id) values ('32', 5);
insert into CinemaGenre (cinema_id, genre_id) values ('33', 17);
insert into CinemaGenre (cinema_id, genre_id) values ('34', 20);
insert into CinemaGenre (cinema_id, genre_id) values ('35', 11);
insert into CinemaGenre (cinema_id, genre_id) values ('36', 14);
insert into CinemaGenre (cinema_id, genre_id) values ('37', 15);
insert into CinemaGenre (cinema_id, genre_id) values ('38', 7);
insert into CinemaGenre (cinema_id, genre_id) values ('39', 17);
insert into CinemaGenre (cinema_id, genre_id) values ('40', 10);
insert into CinemaGenre (cinema_id, genre_id) values ('41', 16);
insert into CinemaGenre (cinema_id, genre_id) values ('42', 7);
insert into CinemaGenre (cinema_id, genre_id) values ('43', 10);
insert into CinemaGenre (cinema_id, genre_id) values ('44', 15);
insert into CinemaGenre (cinema_id, genre_id) values ('45', 9);
insert into CinemaGenre (cinema_id, genre_id) values ('46', 3);
insert into CinemaGenre (cinema_id, genre_id) values ('47', 2);
insert into CinemaGenre (cinema_id, genre_id) values ('48', 6);
insert into CinemaGenre (cinema_id, genre_id) values ('49', 15);
insert into CinemaGenre (cinema_id, genre_id) values ('50', 15);

--VIEWING CLASSIFICATION INSERT
insert into ViewingClassification (viewing_classification_name) values ('Violence');
insert into ViewingClassification (viewing_classification_name) values ('Gore');
insert into ViewingClassification (viewing_classification_name) values ('Sex');
insert into ViewingClassification (viewing_classification_name) values ('Swearing');
insert into ViewingClassification (viewing_classification_name) values ('Drug and Alcohol Abuse');


--CINEMA VIEWING CLASSIFICATION INSERT
insert into CinemaViewingClassification (cinema_id, viewing_classifciation_id) values ('33', '2');
insert into CinemaViewingClassification (cinema_id, viewing_classifciation_id) values ('30', '5');
insert into CinemaViewingClassification (cinema_id, viewing_classifciation_id) values ('3', '1');
insert into CinemaViewingClassification (cinema_id, viewing_classifciation_id) values ('22', '3');
insert into CinemaViewingClassification (cinema_id, viewing_classifciation_id) values ('27', '4');
insert into CinemaViewingClassification (cinema_id, viewing_classifciation_id) values ('28', '5');
insert into CinemaViewingClassification (cinema_id, viewing_classifciation_id) values ('16', '2');
insert into CinemaViewingClassification (cinema_id, viewing_classifciation_id) values ('49', '4');
insert into CinemaViewingClassification (cinema_id, viewing_classifciation_id) values ('24', '3');
insert into CinemaViewingClassification (cinema_id, viewing_classifciation_id) values ('21', '1');

--SEASON INSERT
insert into Season (season_name, season_description, season_number, cinema_id) values ('id mauris', 'Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis. Ut at dolor quis odio consequat varius.', 4, '1');
insert into Season (season_name, season_description, season_number, cinema_id) values ('ut rhoncus aliquet', 'Vestibulum ac est lacinia nisi venenatis tristique. Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue. Aliquam erat volutpat.', 3, '2');
insert into Season (season_name, season_description, season_number, cinema_id) values ('sollicitudin vitae consectetuer', 'Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum. Aliquam non mauris.', 2, '3');
insert into Season (season_name, season_description, season_number, cinema_id) values ('vivamus tortor', 'In hac habitasse platea dictumst. Etiam faucibus cursus urna. Ut tellus.', 3, '4');
insert into Season (season_name, season_description, season_number, cinema_id) values ('curabitur convallis duis consequat dui', 'Etiam vel augue. Vestibulum rutrum rutrum neque. Aenean auctor gravida sem.', 1, '5');
insert into Season (season_name, season_description, season_number, cinema_id) values ('nulla sed vel', 'Fusce consequat. Nulla nisl. Nunc nisl.', 3, '6');
insert into Season (season_name, season_description, season_number, cinema_id) values ('amet', 'In congue. Etiam justo. Etiam pretium iaculis justo.', 4, '7');
insert into Season (season_name, season_description, season_number, cinema_id) values ('platea dictumst maecenas ut', 'Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis. Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero.', 4, '8');
insert into Season (season_name, season_description, season_number, cinema_id) values ('amet consectetuer', 'tra, magna vestibnon mi. Integer ac neque.', 5, '9');
insert into Season (season_name, season_description, season_number, cinema_id) values ('nulla justo', 'Fusce consequat. Nulla nisl. Nunc nisl.', 4, '10');
insert into Season (season_name, season_description, season_number, cinema_id) values ('sit', 'Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vivamus vestibulum sagittis sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.', 4, '11');
insert into Season (season_name, season_description, season_number, cinema_id) values ('venenatis tristique', 'Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus. Duis at velit eu est congue elementum.', 4, '12');
insert into Season (season_name, season_description, season_number, cinema_id) values ('quis augue luctus tincidunt nulla', 'Praesent id massa id nisl venenatis lacinia. Aenean sit amet justo. Morbi ut odio.', 5, '13');
insert into Season (season_name, season_description, season_number, cinema_id) values ('duis bibendum felis sed', 'Quisque porta volutpat erat. Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus.', 3, '14');
insert into Season (season_name, season_description, season_number, cinema_id) values ('luctus rutrum nulla tellus', 'In congue. Etiam justo. Etiam pretium iaculis justo.', 3, '15');
insert into Season (season_name, season_description, season_number, cinema_id) values ('morbi sem mauris laoreet ut', 'Duis bibendum. Morbi non quam nec dui luctus rutrum. Nulla tellus.', 2, '16');
insert into Season (season_name, season_description, season_number, cinema_id) values ('mollis molestie lorem quisque ut', 'Etiam vel augue. Vestibulum rutrum rutrum neque. Aenean auctor gravida sem.', 4, '17');
insert into Season (season_name, season_description, season_number, cinema_id) values ('eu', 'Praesent id massa id nisl venenatis lacinia. Aenean sit amet justo. Morbi ut odio.', 3, '18');
insert into Season (season_name, season_description, season_number, cinema_id) values ('turpis integer aliquet', 'Praesent id massa id nisl venenatis lacinia. Aenean sit amet justo. Morbi ut odio.', 5, '19');
insert into Season (season_name, season_description, season_number, cinema_id) values ('pretium iaculis justo in hac', 'In hac habitasse platea dictumst. Etiam faucibus cursus urna. Ut tellus.', 3, '20');


-- EPISODE INSERT
insert into Episode (episode_number, episode_name, episode_descriotion, episode_duration, season_id) values (40, 'Brittlebank', 'Silver gull', null, '7');
insert into Episode (episode_number, episode_name, episode_descriotion, episode_duration, season_id) values (38, 'Roobottom', 'Macaw, scarlet', null, '15');
insert into Episode (episode_number, episode_name, episode_descriotion, episode_duration, season_id) values (75, 'Strongman', 'Black rhinoceros', null, '4');
insert into Episode (episode_number, episode_name, episode_descriotion, episode_duration, season_id) values (2, 'Balk', 'Ox, musk', null, '12');
insert into Episode (episode_number, episode_name, episode_descriotion, episode_duration, season_id) values (18, 'Schroeder', 'Snake (unidentified)', null, '19');
insert into Episode (episode_number, episode_name, episode_descriotion, episode_duration, season_id) values (29, 'Geely', 'Green heron', null, '18');
insert into Episode (episode_number, episode_name, episode_descriotion, episode_duration, season_id) values (70, 'Leavold', 'Eastern quoll', null, '8');
insert into Episode (episode_number, episode_name, episode_descriotion, episode_duration, season_id) values (36, 'Vlasin', 'Long-tailed skua', null, '5');
insert into Episode (episode_number, episode_name, episode_descriotion, episode_duration, season_id) values (58, 'Lauderdale', 'Possum, pygmy', null, '14');
insert into Episode (episode_number, episode_name, episode_descriotion, episode_duration, season_id) values (74, 'MacGibbon', 'Skunk, western spotted', null, '2');

--SUBTITLE INSERT
insert into Subtitle (subtitle_text, language_id, cinema_id) values ('Vivamus in felis eu sapien cursus vestibulum. Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem.', '20', '42');
insert into Subtitle (subtitle_text, language_id, cinema_id) values ('Nunc purus. Phasellus in felis.', '4', '12');
insert into Subtitle (subtitle_text, language_id, cinema_id) values ('Suspendisse potenti. In eleifend quam a odio.', '12', '20');
insert into Subtitle (subtitle_text, language_id, cinema_id) values ('Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy. Integer non velit.', '8', '7');
insert into Subtitle (subtitle_text, language_id, cinema_id) values ('Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis. Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl.', '28', '14');
insert into Subtitle (subtitle_text, language_id, cinema_id) values ('Nulla justo. Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros.', '5', '35');
insert into Subtitle (subtitle_text, language_id, cinema_id) values ('Etiam vel augue. Vestibulum rutrum rutrum neque.', '29', '16');
insert into Subtitle (subtitle_text, language_id, cinema_id) values ('Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus. Curabitur at ipsum ac tellus semper interdum. Mauris ullamcorper purus sit amet nulla.', '22', '40');
insert into Subtitle (subtitle_text, language_id, cinema_id) values ('Suspendisse accumsan tortor quis turpis. Sed ante.', '11', '25');
insert into Subtitle (subtitle_text, language_id, cinema_id) values ('Donec quis orci eget orci vehicula condimentum. Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est.', '19', '10');
insert into Subtitle (subtitle_text, language_id, cinema_id) values ('Nulla nisl. Nunc nisl. Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus.', '16', '6');
insert into Subtitle (subtitle_text, language_id, cinema_id) values ('Vivamus tortor.', '14', '45');
insert into Subtitle (subtitle_text, language_id, cinema_id) values ('Duis at velit eu est congue elementum. In hac habitasse platea dictumst. Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante.', '21', '18');
insert into Subtitle (subtitle_text, language_id, cinema_id) values ('Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede. Morbi porttitor lorem id ligula.', '27', '37');
insert into Subtitle (subtitle_text, language_id, cinema_id) values ('Curabitur at ipsum ac tellus semper interdum. Mauris ullamcorper purus sit amet nulla.', '15', '48');
insert into Subtitle (subtitle_text, language_id, cinema_id) values ('Nullam molestie nibh in lectus.', '25', '38');
insert into Subtitle (subtitle_text, language_id, cinema_id) values ('Ut at dolor quis odio consequat varius. Integer ac leo.', '18', '29');
insert into Subtitle (subtitle_text, language_id, cinema_id) values ('Duis aliquam convallis nunc.', '26', '34');
insert into Subtitle (subtitle_text, language_id, cinema_id) values ('Cras non velit nec nisi vulputate nonummy. Maecenas tincidunt lacus at velit. Vivamus vel nulla eget eros elementum pellentesque.', '3', '27');
insert into Subtitle (subtitle_text, language_id, cinema_id) values ('Nullam molestie nibh in lectus.', '17', '46');
insert into Subtitle (subtitle_text, language_id, cinema_id) values ('Nullam molestie nibh in lectus.', 32, 42);
insert into Subtitle (subtitle_text, language_id, cinema_id) values ('Nullam molestie nibh in lectus.', 31, 40);

-- USER INSERT
insert into [User] (user_email, user_password, date_of_birth, login_attempts, is_blocked, activation_date, subscription_id, invited_by) values ('ebagby0@domainmarket.com', 'hi8zAgT', '2015-04-07', 2, 1, '2022-04-27', 1, 1);
insert into [User] (user_email, user_password, date_of_birth, login_attempts, is_blocked, activation_date, subscription_id, invited_by) values ('vdarbon1@mtv.com', 'uAd9TOSVMCjX', '1932-01-21', 2, 1, '2022-03-20', 2, 7);
insert into [User] (user_email, user_password, date_of_birth, login_attempts, is_blocked, activation_date, subscription_id, invited_by) values ('cnunan2@newsvine.com', 'QZqJHQgmf', '1963-10-05', 3, 0, '2022-05-27', 2, 9);
insert into [User] (user_email, user_password, date_of_birth, login_attempts, is_blocked,  subscription_id, invited_by) values ('eatwill3@networkadvertising.org', 'zkNSsQG', '1959-11-19', 1, 1, 1, 2);
insert into [User] (user_email, user_password, date_of_birth, login_attempts, is_blocked, activation_date, subscription_id, invited_by) values ('aabdy4@soup.io', 'fADySxvIItiS', '2011-04-24', 1, 0, '2021-09-17', 3, 2);
insert into [User] (user_email, user_password, date_of_birth, login_attempts, is_blocked, activation_date, subscription_id, invited_by) values ('dohannigan5@census.gov', 'Pe1y6YZfhh8', '1949-10-29', 1, 0, '2022-01-06', 1, 10);
insert into [User] (user_email, user_password, date_of_birth, login_attempts, is_blocked, activation_date, subscription_id, invited_by) values ('fmccloughlin6@reference.com', 'HwsdYPSPLfEZ', '1999-11-29', 2, 1, '2022-05-16', 3, 10);
insert into [User] (user_email, user_password, date_of_birth, login_attempts, is_blocked, activation_date, subscription_id, invited_by) values ('escurrer7@ezinearticles.com', 'J37RvXa', '2018-01-21', 3, 1, '2021-08-10', 2, 4);
insert into [User] (user_email, user_password, date_of_birth, login_attempts, is_blocked, activation_date, subscription_id) values ('fpetriello8@google.com.au', 'IsQvthAgIP0', '1940-09-12', 3, 0, '2021-11-06', 1);
insert into [User] (user_email, user_password, date_of_birth, login_attempts, is_blocked, activation_date) values ('rmabon9@hugedomains.com', 'CicBN19k', '1994-10-12', 1, 1, '2022-06-30');

--PROFILE INSERT
insert into Profile (profile_name, date_of_birth, photo, user_id, language_id) values ('Jeanette', '1932-12-31', null, 2, 1);
insert into Profile (profile_name, date_of_birth, photo, user_id, language_id) values ('Dru', '1974-09-23', null, 3, 1);
insert into Profile (profile_name, date_of_birth, photo, user_id, language_id) values ('Rubie', '1969-06-23', null, 8, 1);
insert into Profile (profile_name, date_of_birth, photo, user_id, language_id) values ('Alasdair', '1902-07-25', null, 2, 1);
insert into Profile (profile_name, date_of_birth, photo, user_id, language_id) values ('Annabel', '2012-03-03', null, 2, 10);
insert into Profile (profile_name, date_of_birth, photo, user_id, language_id) values ('Calypso', '1983-11-18', null, 2, 22);
insert into Profile (profile_name, date_of_birth, photo, user_id, language_id) values ('Reynard', '1938-02-17', null, 5, 13);
insert into Profile (profile_name, date_of_birth, photo, user_id, language_id) values ('Say', '2014-02-09', null, 5, 8);
insert into Profile (profile_name, date_of_birth, photo, user_id, language_id) values ('Marlo', '1935-11-10', null, 1, 5);
insert into Profile (profile_name, date_of_birth, photo, user_id, language_id) values ('Sharline', '2005-09-17', null, 3, 1);
insert into Profile (profile_name, date_of_birth, photo, user_id, language_id) values ('Kerry', '1914-01-02', null, 1, 18);
insert into Profile (profile_name, date_of_birth, photo, user_id, language_id) values ('Flory', '2000-09-27', null, 7, 20);
insert into Profile (profile_name, date_of_birth, photo, user_id, language_id) values ('Nat', '1920-08-16', null, 2, 26);
insert into Profile (profile_name, date_of_birth, photo, user_id, language_id) values ('Silvanus', '1937-11-18', null, 9, 13);
insert into Profile (profile_name, date_of_birth, photo, user_id, language_id) values ('Harrison', '1978-05-16', null, 7, 14);


--PREFERENCE INSERT
insert into Preference (interested_in_series, minimum_age, profile_id) values (1, 12, 8);
insert into Preference (interested_in_series, minimum_age, profile_id) values (0, 18, 11);
insert into Preference (interested_in_series, minimum_age, profile_id) values (0, 0, 2);
insert into Preference (interested_in_series, minimum_age, profile_id) values (0, 15, 15);
insert into Preference (interested_in_series, minimum_age, profile_id) values (0, 0, 15);
insert into Preference (interested_in_series, minimum_age, profile_id) values (0, 21, 13);
insert into Preference (interested_in_series, minimum_age, profile_id) values (1, 15, 2);
insert into Preference (interested_in_series, minimum_age, profile_id) values (0, 5, 5);
insert into Preference (interested_in_series, minimum_age, profile_id) values (0, 12, 6);
insert into Preference (interested_in_series, minimum_age, profile_id) values (1, 5, 4);


--GENRE PREFERENCE INSERT
insert into GenrePreference (genre_id, preference_id) values (9, '10');
insert into GenrePreference (genre_id, preference_id) values (9, '1');
insert into GenrePreference (genre_id, preference_id) values (3, '9');
insert into GenrePreference (genre_id, preference_id) values (14, '5');
insert into GenrePreference (genre_id, preference_id) values (8, '8');
insert into GenrePreference (genre_id, preference_id) values (9, '2');
insert into GenrePreference (genre_id, preference_id) values (1, '4');
insert into GenrePreference (genre_id, preference_id) values (11, '6');
insert into GenrePreference (genre_id, preference_id) values (9, '7');
insert into GenrePreference (genre_id, preference_id) values (13, '3');

-- WATCHLIST INSERT
insert into Watchlist (profile_id, title_id) values ('5', '50');
insert into Watchlist (profile_id, title_id) values ('4', '3');
insert into Watchlist (profile_id, title_id) values ('7', '11');
insert into Watchlist (profile_id, title_id) values ('9', '19');
insert into Watchlist (profile_id, title_id) values ('13', '1');
insert into Watchlist (profile_id, title_id) values ('11', '42');
insert into Watchlist (profile_id, title_id) values ('6', '33');
insert into Watchlist (profile_id, title_id) values ('15', '2');
insert into Watchlist (profile_id, title_id) values ('14', '8');
insert into Watchlist (profile_id, title_id) values ('8', '12');

-- WATCH LATER INSERT
insert into Wacthlater (profile_id, cinema_id) values ('6', '49');
insert into Wacthlater (profile_id, cinema_id) values ('9', '15');
insert into Wacthlater (profile_id, cinema_id) values ('2', '16');
insert into Wacthlater (profile_id, cinema_id) values ('7', '23');
insert into Wacthlater (profile_id, cinema_id) values ('12', '22');
insert into Wacthlater (profile_id, cinema_id) values ('3', '25');
insert into Wacthlater (profile_id, cinema_id) values ('15', '20');
insert into Wacthlater (profile_id, cinema_id) values ('13', '26');
insert into Wacthlater (profile_id, cinema_id) values ('14', '38');
insert into Wacthlater (profile_id, cinema_id) values ('8', '18');


--VIEWED LIST INSERT
insert into ViewedList (date_watched , profile_id, cinema_id, subtitle_id) values ('2022-06-21', 8, 13, 17);
insert into ViewedList (date_watched , profile_id, cinema_id, subtitle_id) values ('2022-05-25', 13, 46, 18);
insert into ViewedList (date_watched , profile_id, cinema_id, subtitle_id) values ('2021-10-25', 3, 45, 9);
insert into ViewedList (date_watched , profile_id, cinema_id, subtitle_id) values ('2022-01-29', 8, 6, 1);
insert into ViewedList (date_watched , profile_id, cinema_id, subtitle_id) values ('2021-07-27', 1, 33, 15);
insert into ViewedList (date_watched , profile_id, cinema_id, subtitle_id) values ('2022-05-25', 9, 35, 12);
insert into ViewedList (date_watched , profile_id, cinema_id, subtitle_id) values ('2021-09-17', 5, 36, 16);
insert into ViewedList (date_watched , profile_id, cinema_id, subtitle_id) values ('2021-12-05', 10, 35, 4);
insert into ViewedList (date_watched , profile_id, cinema_id) values ('2021-12-11', 3, 6);
insert into ViewedList (date_watched , profile_id, cinema_id, subtitle_id) values ('2022-01-12', 12, 1, 19);
insert into ViewedList (date_watched , profile_id, cinema_id, subtitle_id) values ('2021-12-11', 3, 17, 21);
insert into ViewedList (date_watched , profile_id, cinema_id, subtitle_id) values ('2022-01-12', 7, 32, 22);
insert into ViewedList (date_watched , profile_id, cinema_id, subtitle_id) values ('2022-03-28', 7, 51, 10);
insert into ViewedList (date_watched , profile_id, cinema_id) values ('2022-07-19',1, 51);
insert into ViewedList (date_watched , profile_id, cinema_id, subtitle_id) values ('2022-02-14', 3, 17, 1);
insert into ViewedList (date_watched , profile_id, cinema_id, subtitle_id) values ('2022-02-14', 7, 32, 2);
insert into ViewedList (date_watched , profile_id, cinema_id, subtitle_id) values ('2022-02-14', 7, 51, 1);
insert into ViewedList (date_watched , profile_id, cinema_id, subtitle_id) values ('2022-02-14', 7, 32, 2);
insert into ViewedList (date_watched , profile_id, cinema_id, subtitle_id) values ('2022-02-14', 7, 51, 1);
insert into ViewedList (date_watched , profile_id, cinema_id, subtitle_id) values ('2022-02-14', 7, 32, 3);
insert into ViewedList (date_watched , profile_id, cinema_id, subtitle_id) values ('2022-02-14', 7, 51, 4);
insert into ViewedList (date_watched , profile_id, cinema_id, subtitle_id) values ('2022-02-14', 7, 32, 5);
insert into ViewedList (date_watched , profile_id, cinema_id, subtitle_id) values ('2022-02-14', 7, 51, 5);


-- VIEWING CLASSIFICATION PREFERENCE 
insert into ViewingClassificationPreference (viewing_classification_id, preference_id) values ('5', '4');
insert into ViewingClassificationPreference (viewing_classification_id, preference_id) values ('3', '2');
insert into ViewingClassificationPreference (viewing_classification_id, preference_id) values ('1', '10');
insert into ViewingClassificationPreference (viewing_classification_id, preference_id) values ('2', '5');
insert into ViewingClassificationPreference (viewing_classification_id, preference_id) values ('4', '6');
insert into ViewingClassificationPreference (viewing_classification_id, preference_id) values ('2', '7');
insert into ViewingClassificationPreference (viewing_classification_id, preference_id) values ('1', '3');
insert into ViewingClassificationPreference (viewing_classification_id, preference_id) values ('5', '8');
insert into ViewingClassificationPreference (viewing_classification_id, preference_id) values ('3', '9');
insert into ViewingClassificationPreference (viewing_classification_id, preference_id) values ('4', '1');


GO