# TotallyAwesomeQuizz
# 1. Тема на проектна задача
Темата на проектната задача е мала игра во кога корисникот одговара сет прашања и според дадените одговори на крајот се дава мал опис на карактерот на корисникот.
Правила на играта и начин на играње
Играчот му се претставени разни прашања со претходно понудени одговори или со text-field за дополнување, при успешно избран одговор играта автоматски преминува на следното прашање.
На крајот на играта на корисникот му се понудени опции за да види резултати и опција за излез од апликацијата
Изглед на играта
# 2. Правила на играта и начин на играње
Играчот му се претставени разни прашања со претходно понудени одговори или со text-field за дополнување, при успешно избран одговор играта автоматски преминува на следното прашање.
На крајот на играта на корисникот му се понудени опции за да види резултати и опција за излез од апликацијата
# 3. Изглед на играта
На почетониот прозорец има 4 делови, тект поле каде што пишува "Welcome to the Awesome Quizz!", инпут поле каде што треба да се внесе името на играчот, чекбокс каде што играчот искажува дали е спремен да игра, и Старт копче кое носи до нов прозорец со следното прашање
Сите прозорци се со црна позадина и зелен текст.
# 4. Податочни Структури
Има севкупно 9 класи
Program, Player, Form1, Form2, Form3, Form4, Form5, Form6, и Form7.
**Program** само служи за почеток на програмата. 
Во **Player** се чуваат различни променливи, **introversion extroversion empathy responsibility breavery favSeason favMovie**, кои ги мерат карактеристиките на играчот како и методи за инкрементација на истите. Тука се наоѓа и методата **giveResults()**.
```C#
 public string giveResults()
        {
            string results = "";
            results = "Hello, your name is " + this.Name + ", your favourite season is " + this.favSeason + " and your favourite movie is " + this.favMovie + ".\n You ";

            if (this.bravery > 0)
                results += "are brave,";
            else
                results += "are not very brave,";

            if(this.introversion>0 && this.extroversion > 0)
            {
                results += " both introverted and extroverted depending on the sittuation,";
            }
            else
            {
                if (this.introversion > 0)
                {
                    results += " slightly introverted,";
                }
                
                if(this.extroversion > 0)
                {
                    results += " slightly extroverted,";
                }
            }
            
            if(this.empathy > 0)
            {
                results += " tend to emphatise with people easly,";
            }
            else
            {
                results += " don't emphatise with people easly,";
            }

            if(this.responsibility > 0)
            {
                results += " and are pretty responsible!";
            }
            else
            {
                results += " and you could work on your responsibility a bit.";
            }

            return results;

```
Во методата **giveResults()** се прави нов стринг, на кој во зависност од карактеристиките на играчот се додаваат различни описи. Целиот резултат може послем да биде прикажан додека играчот избере. 
Во сите Form класи има методи за кога копче на одговор е притиснато, во тие методи се инкрементира некоја карактеристика на играчот и се продолжува до следното прашање/следниот Form.
