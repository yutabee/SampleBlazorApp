//Blazorを開始する前に呼び出される関数
export function beforeStart(options, extensions) {
    console.log("before Start");
}
//Blazorの準備が完了したら呼び出される関数
export function afterStarted(blazor) {
    console.log("after Started");
}
//独自に作成した処理
//windowプロパティにメソッドとして関数を代入
window.say = (message) => {
    alert(message);
}

window.ask = (message) => {
    return prompt(message, '');
}