<template>
    	<div style="margin-top: -60px">
	<div class="header bg-info">
		<div class="container">
		<div class="row">
			<div class="logo col-sm-3">
				<img src="../images/logo1.png" style="width: 140px;height: 62px;">
			</div>	
			<ul class="nav justify-content-end col navbar-expand-sm mt-2" style="backgroud-color: black">
				<li class="nav-item "><a href="page" class="nav-link text-white" style="font-family: Arial, Helvetica, sans-serif;"><i class="fas fa-home"></i> Trang chủ</a></li>
				<li class="nav-item "><a href="gioithieu" class="nav-link text-white" style="font-family: Arial, Helvetica, sans-serif;"><i class="fab fa-chrome"></i> Giới thiệu</a></li>
				<li class="nav-item"><a href="datve" class="nav-link text-white" style="font-family: Arial, Helvetica, sans-serif;"><i class="fas fa-address-book"></i> Đặt vé</a></li>
			<div class="dropdown">
  				<button class="dropbtn bg-info"><i class="fas fa-search"></i> Tìm kiếm</button>
  			<div class="dropdown-content">
    			<a href="timkiemve">Thông tin vé</a>
    			<a href="timkiemtuyen">Thông tin tuyến</a>
    			<a href="timkiemchuyen">Thông tin chuyến</a>
  			</div>
			</div>
				<li class="nav-item"><a href="qly" class="nav-link text-dark" style="font-family: Arial, Helvetica, sans-serif;"><i class="fas fa-user"></i> admin
					</a></li>
			</ul>
			</div>
		</div>
	</div>
    
    <div class="container">
        <div class="row">
		<form action="" class="border p-4 m-5 col-sm-6">
			<h4 class="text-info">Nhập thông tin</h4>
		<div class="form-group">
			<input type="ten" class="form-control" name="ten" placeholder="Tên khách hàng" v-model="thongtinve.tenKh" required>
		</div>
		<div class="form-group">
			<input type="sdt" class="form-control" name="sdt" placeholder="Số điện thoại" v-model="thongtinve.soDt" required>
		</div>
		<div class="form-group">
			<select name="tuyen" class="form-control" id="" v-model="thongtinve.tuyen" required>
				<option value="">Chọn tuyến đường</option>
                <option v-for="thongtintuyen in thongtintuyens" :key="thongtintuyen.tuyen">{{ thongtintuyen.tuyen }}</option>
            </select>
		</div>
		<div class="form-group">
            <label for="">Ngày đi: </label>
            <input type="datetime-local" class="form-control" name="ngay" v-model="thongtinve.thoiGian" required>
		</div>
		<div class="form-group">
            <label for="">Loại vé:</label>
			<select  class="form-control" id="" v-model="thongtinve.loaiVe" required>
                <option value="Vé thường">Vé thường</option>
                <option value="Vé VIP">Vé VIP</option>
            </select>
		</div>
        <div id = "datve">
		<button class="btn btn-success" @click="saveEmploy">Đặt vé</button>
        </div>
		</form>
        <div class=" font-italic col-sm-4 mt-5 ml-2">
		<p>** Quý khách có thể đặt vé qua tổng đài phục vụ 24/24 của chúng tôi(kể cả thứ 7 và Chủ Nhật)
            : 1900 0019 hoặc mua vé tiện lợi ngay trên chiếc điện thoại thông minh của quý vị thông qua website của chúng tôi.
        </p>
		<p>VeXeRe là hệ thống đặt vé xe khách trực tuyến lớn nhất Việt Nam. Hỗ trợ đặt vé với hơn 5000 tuyến đường xe liên tỉnh
			 trong và ngoài nước. Không chỉ mang đến giải pháp đặt vé xe an toàn, nhanh chóng với đa dạng lựa chọn về loại xe và 
			 hãng xe. VeXeRe còn có rất nhiều ưu đãi đặt vé hàng tháng, giúp hàng khách dễ dàng đặt được vé xe với giá vé tốt nhất.</p>
		<h4 class="text-success">Hotline: 1900 0019</h4>
	</div>
</div>
<img src="../images/datve.jpg" style="width: 100%;height: 100%;">
	</div>
    <br>
	<div class="footer_bg bg-info">
	<div class="footer p-3">
		<div class="container">
			<div class="row">
				<div class="col-md-4">
					<h3 class="text-white">Mạng xã hội</h3>
					<ul class="nav ml-5">
						<li class="nav-item mr-3"><a href="" class="nav-item text-secondary"><img src="../images/fb.png" style="width: 35px;height: 35px;"></a></li>
						<li class="nav-item mr-3"><a href="" class="nav-item text-secondary"><img src="../images/tw.png" style="width: 35px;height: 35px;"></a></li>
						<li class="nav-item mr-3"><a href="" class="nav-item text-secondary"><img src="../images/gg.png" style="width: 35px;height: 35px;"></a></li>
						<li class="nav-item mr-3"><a href="" class="nav-item text-secondary"><img src="../images/ins.png" style="width: 35px;height: 35px;"></a></li>
					</ul>
				</div>
				<div class="col-md-6">
					<h3 class="text-white">Liên hệ</h3>
					<ul class="nav flex-column">
						<li class="nav-item text-white"><i class="fas fa-address-book"></i> Địa chỉ: Bala, Hà Đông, Hà Nội</li>
						<li class="nav-item text-white"><i class="fas fa-phone-square-alt"></i> Phone: 0123456789</li>
						<li class="nav-item text-white"><i class="fas fa-envelope"></i> Email: xekhachre@gmail.com</li>
						<li class="nav-item text-white">Công ty TNHH ABCD (MST 12924129832)</li>
					</ul>
				</div>
			</div>
		</div>
	</div>
</div>	
    </div>
</template>

<script>
import axios from 'axios'
export default {
    name:'ThongTinVe',
 data(){
    return{
		thongtintuyens: [],
        thongtinve:{
            tenKh:'',
			soDt:'',
            tuyen:'',
            thoiGian:'',
			loaive:''
        },
		
    }
 },
 
 methods:{
    saveEmploy(){
        axios.post('http://localhost:5211/api/ThongTinVe',this.thongtinve)
    }
 },
 mounted:function(){
axios.get('http://localhost:5211/api/ThongTinTuyen')
.then(response=>{
    if(response.data){
        this.thongtintuyens = response.data
    }
})
.catch(e=>{
    console.log("lỗi",e)
})
}
 
}
</script>

<style>
.dropbtn {
  color: white;
  margin-top: 8px;
  font-size: 16px;
  border: none;
}

.dropdown {
  position: relative;
  display: inline-block;
}

.dropdown-content {
  display: none;
  position: absolute;
  background-color: #f1f1f1;
  min-width: 160px;
  box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);
  z-index: 1;
}

.dropdown-content a {
  color: black;
  padding: 12px 16px;
  text-decoration: none;
  display: block;
}

.dropdown-content a:hover {background-color: #ddd;}

.dropdown:hover .dropdown-content {display: block;}

.dropdown:hover .dropbtn {background-color: #3e8e41;}
</style>