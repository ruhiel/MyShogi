﻿
# USI 2.0

USIプロトコルは、将棋エンジンで幅広く使われているが、現代の将棋エンジンの仕様として問題点が色々あるので、独自に拡張したUSI 2.0というプロトコルを定義する。

# 例

- 手数が伸びてきたときに、初期局面から毎回エンジンに送るのは無駄であって、前回局面の続き(最大2手)を送れば十分である。"posdiff move1 move2"

- かきかけ

