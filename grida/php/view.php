<?php
    $connect = mysql_connect("localhost", "cozco2", "cell2242");
    mysql_select_db("cozco2",$connect);
    mysql_query("set names utf8");


$bNo = $_GET['bno'];

$sql = 'select title, content, date, hit, id from board_free where b_no = ' . $bNo;
$result = $db->query($sql);
$row = $result->fetch_assoc();
?>
<!DOCTYPE html>
<html>
<head>
<meta charset="utf-8" />
<title>자유게시판 | Kurien's Library</title>
<link rel="stylesheet" href="./css/normalize.css" />
<link rel="stylesheet" href="./css/board.css" />
</head>
<body>
<article class="boardArticle">
<h3>자유게시판 글쓰기</h3>
<div id="boardView">
<h3 id="boardTitle"><?php echo $row['b_title']?></h3>
<div id="boardInfo">
<span id="boardID">작성자: <?php echo $row['b_id']?></span>
<span id="boardDate">작성일: <?php echo $row['b_date']?></span>
<span id="boardHit">조회: <?php echo $row['b_hit']?></span>
</div>
<div id="boardContent"><?php echo $row['b_content']?></div>
</div>
</article>
</body>
</html>