# DemoNetCoreDesignPattern

---------------------------------------

## 建立型模式

> 隱藏了這些類別的實體是如何被建立和放在一起，整個系統關於這些物件所知道的，是由抽象類別所定義的介面。這樣，建立型模式在建立了什麼、誰建立它、它是怎麼被建立的，以及何時建立這些方面提供了很大的靈活性。

* 工廠方法模式 (Factory Method Pattern)
* 單例模式 (Singleton Pattern)
* 建造者模式 (Builder Pattern)
* 原形模式 (Prototype Pattern)
* 抽象工廠模式 (Abstract Factory Pattern)

## 結構型模式

> 整理既有的類別，並且將這些類別做一些適當的轉換，最終達到更容易使用、更加靈活、變化他們的表示等等的效果。

* 裝飾模式 (Decorator Pattern)
* 轉接器模式 (Adapter Pattern)
* 代理模式 (Proxy Pattern)
* 外觀模式 (Facade Pattern)
* 享元模式 (Flyweight Pattern)
* 組合模式 (Composite Pattern)
* 橋接模式 (Bridge Patern)

## 行為型模式

> 用來識別對象之間的常用交流模式並加以實現。如此，可在進行這些交流活動時增強彈性。

* 策略模式 (Strategy Pattern)
* 觀察者模式 (Observer Pattern)
* 命令模式 (Command Pattern)
* 範本方法模式 (TemplateMethod Pattern)
* 狀態模式 (State Pattern)
* 備忘錄模式 (Memoto Pattern)
* 迭代器模式 (Iterator Pattern)
* 中介者模式 (Mediator Pattern)
* 責任鍊模式 (Chain Of Responsibility Pattern)
* 解釋器模式 (Interpreter Pattern)
* 訪問者模式 (Visitor Pattern)

---------------------------------------

## 工廠方法模式 (Factory Method Pattern)

> 定義一個用於建立物品的介面，讓子類決定實體化哪一個類別。工廠方法使一個類別的實例化延遲到其子類別。

## 策略模式 (Strategy Pattern)

> 定義一系列的演算法，並且把這些算法，用介面封裝到有公共介面的策略類中，使他們可以互相替換。

## 單例模式 (Singleton)

> 只有一個實例，而且自行實例化並向整個系統提供這個實例。

## 裝飾模式 (Decorator)

> 動態的給一個類別添加額外的職責。就增加功能來說，裝飾模式相比產生子類別更為靈活。

## 觀察者模式 (Observer Pattern)

> 一種一對多的依賴關係，當物件的狀態改變，所有依賴於它的物件都會得到通知並被自動更新。

## 命令模式 (Command Pattern)

> 將請求傳送者和接收者完全解耦，傳送者與接收者之間沒有直接引用關係，傳送請求的物件只需要知道如何傳送請求，而不必知道如何完成請求。

## 建造者模式 (Builder Pattern)

> 分離一個複雜物品的建造和表示建造的方式。

## 範本方法模式 (Template Method Pattern)

> 把某些行為或定義推遲到子類別實現，所以可以很簡單的在不改變程式基礎骨架的狀況下，繼承其範本方法，拓展不同的行為方式。

## 轉接器模式 (Adapter Pattern)

> 用一個介面來轉換另一個已存在的類別。這是經常被使用來用一個已存在的類別，用一個介面來包裝已存在類別使兩個不相容的類別可以共同工作。

## 代理模式 (Proxy Pattern)

> 為其他物件提供一種代理以控制對這個物件的存取。

## 原形模式 (Prototype Pattern)

> 從一個物件再建立另外一個可訂製的物件，而且不需要知道任何建立的細節。

## 外觀模式 (Facade Pattern)

> 為子系統中的一組介面提供一個一致的介面，此模式定義了一個高階介面，這個介面使得這一子系統更加容易使用。

## 狀態模式 (State Pattern)

> 當一個物件的內在狀態改變時允許改變其行為，這個物件看起來像是改變了其類別。

## 備忘錄模式 (Memoto Pattern)

> 在不破壞封裝性的前提之下，捕獲一個物件的內部狀態，並在該物件之外保存這個狀態。這樣以後就可將該物件恢復到原先保存的狀態。

## 享元模式 (Flyweight Pattern)

> 運用共有技術有效的支援大量細粒度的物件。

## 組合模式 (Composite Pattern)

> 將物件組合成樹形結構以表示「 部分 - 整體 」的層次結構。

## 迭代器模式 (Iterator Pattern)

> 提供一種方法依序存取一個聚合物件中各個元素，而又不暴露該物件的內部表示。

## 橋接模式 (Bridge Pattern)

> 將抽象部分與它的實現部分分離，使它們都可以獨立地變化。

## 責任鍊模式 (Chain Of Responsibility Pattern)

> 使多個物件都有機會處理請求，從而避免請求的發送者和接收者之間的耦合關係。將這個物件連成一條鏈，並沿著這條鏈傳遞該請求，直到有一個物件處理它為止。

## 仲介者模式 (Mediator Pattern)

> 使個物件不需要顯式地互相參考，從而使其耦合鬆散，而且可以獨立地改變它們之間的互動。

## 解譯器模式 (Interpreter Pattern)

> 給定一個語言，定義它的語法的一種表示，並定義一個解釋器，這個解釋器使用該表示來解釋語言中的句子。

## 訪問者模式 (Visitor Pattern)

> 表示一個作用於某物件結構中的各元素之操作。它使你可以再不改變各元素之類別的前提之下，定義作用於這些元素的新操作。

## 抽象工廠模式 (Abstract Factory Pattern)

> 提供一個建立一系列相關或互相依賴物件的介面，而無需指定它們具體的類別。

---------------------------------------

## 參考資料

[初探設計模式](https://ithelp.ithome.com.tw/users/20112528/ironman/2113) 

[從生活中認識Design Pattern](https://ithelp.ithome.com.tw/users/20128314/ironman/3070)

[深入淺出設計模式筆記](http://corrupt003-design-pattern.blogspot.com/2017/02/blog-post.html)

[維基百科](https://zh.wikipedia.org/zh-tw/)

[Class Diagram類別圖](https://ithelp.ithome.com.tw/articles/10269231)
