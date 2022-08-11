// 입력 받기
const N = require("fs").readFileSync("/dev/stdin").toString();

// 알고리즘 시작
let result = "";
for (let n = 1; n <= N; n++) {
  for (let m = 1; m <= n; m++) {
    result += "*";
  }
  result += "\n";
}

// 출력 하기
console.log(result);
