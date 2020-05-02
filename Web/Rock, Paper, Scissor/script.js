function play(){
    var things = ['Rock', 'Paper', 'Scissor']
    user_thing = document.getElementById('text1').value;
    if(user_thing == ''){
        window.alert('Enter your thing!');
    }
    else{
        num_random = (((Math.random() * 10) * 2) / 10).toFixed(0);
        bot_thing = things[num_random];
        if (user_thing == 'Rock'){
            if (bot_thing == 'Paper'){
                window.alert(bot_thing);
                window.alert('You lost!');
            }
            else if(bot_thing == 'Scissor'){
                window.alert(bot_thing);
                window.alert('You won!');
            }
            else{
                window.alert(bot_thing);
                window.alert('Equal!');
            }
        }
        else if (user_thing == 'Paper'){
            if (bot_thing == 'Rock'){
                window.alert(bot_thing);
                window.alert('You won!');
            }
            else if(bot_thing == 'Scissor'){
                window.alert(bot_thing);
                window.alert('You lost!');
            }
            else{
                window.alert(bot_thing);
                window.alert('Equal!');
            }
        }
        else{
            if (bot_thing == 'Rock'){
                window.alert(bot_thing);
                window.alert('You lost!');
            }
            else if (bot_thing == 'Paper'){
                window.alert(bot_thing);
                window.alert('You won!');
            }
            else{
                window.alert(bot_thing);
                window.alert('Equal!');
            }
        }
    }


}