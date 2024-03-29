// window 객체는 웹브라우저 전체를 의미한다고 보면 된다.
//398p
//많이 쓰이는건 document 객체를 많이 씀
window.addEventListener('load', function () {
    // 클래스명이  sound인 것을 모두 불러옴(선택함)
    const sounds = document.querySelectorAll(".sound");
    // 클래스 명이 pads 인 태그의 후손 중에서 div태그들 모두 불러옴
    const pads = document.querySelectorAll(".pads div");
    // 클래스이름이 visual 인 태그 하나 선택
    const visual = document.querySelector('.visual');
    // 클래스 이름이 title 인 태그 하나 선택
    const title = document.querySelector('.title');

    //초기화 할때 쓰임
    const color = [" rgb(43, 245, 235)", " rgb(248, 48, 158)", "rgb(253, 172, 51)", "rgb(73, 60, 252)", "rgb(29, 252, 40)", "rgb(247, 62, 216)"];

    //재생되는 음악이 끝나면, .visual에서 비쥬얼과 제목 제거

        sounds.forEach(
            function (snd) {
                snd.onended = function (snd) {
                    visual.innerHTML = "";
                    title.innerHTML = "";
                };
            }

        );
        //위랑 같음 
        // sounds.forEach(snd => {
        //     snd.onended = function(){
        //         visual.innerHTML = "";
        //         title.innerHTML = "";
        //     };
        // });

        // pads.forEach((pad, index) => {
        //     pad.addEventListener('click', function(){
        //         //기존에 재생되는 음악을 중지 시켜야 한다.
        //        sounds.forEach(inx => {
        //         //console.log(inx);
        //         inx.pause();
        //        });
        //        if(sounds[index]){
        //         sounds[index].currentTime = 0;
        //         sounds[index].play();

        //         //뮤직 제목을 출력해 준다.
        //         //console.log(sounds[index].src) ;
        //         const strArray = sounds[index].src.split("sound/");
        //         title.innerHTML = strArray[1];
        //        }
               
        //         //볼만들고 애니메이션 하기
        //         //createBubbles(index);
        //     });
        // });
        pads.forEach(function(pad,index){
                pad.addEventListener('click',function(){
                    //클래승이름이 sound인 태그들 각가에 대하여
                    sounds.forEach(function(inx){
                        //모두 소리를 정지시킨다.
                        inx.pause();
                    });
                //내가 클릭한 태그
                if(sounds[index]){
                    sounds[index].currentTime = 0;
                    sounds[index].play();

                    //뮤직 제목 출력
                    const strArray = sounds[index].src.split("sound/");
                    title.innerHTML = strArray[1];
                }
                    //볼만들고 애니메이션 하기
                    createBubbles(index);

                });    
        });
        const createBubbles = function(index)
        {
            visual.innerHTML = "";
            const bubble = document.createElement("div");
            visual.appendChild(bubble);
            bubble.style.backgroundColor = color[index];
            bubble.style.top='300px';

            bubble.style.animation = 'animation 2000ms linear infinite both';

    }
});