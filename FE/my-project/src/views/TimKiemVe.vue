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
    <br>
    <div class="container">
        <form action="" class="form-inline justify-content-center">
		<div class="form-group ">
			<label for="" style="font-size:25px">Nhập thông tin cần tìm kiếm:</label>
			<input placeholder="" type="text" class="form-control ml-2 mr-2" name="timkiem" v-model="search" >
		</div>
        </form>
    </div>
    <br>
    <marquee style="width:800px;font-size:20px;" class="container" behavior="" direction="">VeXeRe.com - Sàn TMĐT về vé xe lớn nhất Việt Nam, hỗ trợ người dùng đặt vé xe khách một cách dễ dàng, tiện lợi và nhanh chóng. Dùng mã ngay để nhận ưu đãi đến 25% cho đơn hàng đầu tiên của bạn tại VeXeRe nhé!

Đối tượng áp dụng: Áp dụng cho khách hàng lần đầu đặt vé tại VeXeRe.
Thời gian áp dụng: Áp dụng cho ngày khởi hành đến hết 28/12/2022.</marquee>
    <br>
    <h3 class="text-danger mt-4">Thông Tin Vé Đã Đặt:</h3>
    <br>
    <div class="container table-responsive" >
    <table class="table table table-bordered table-striped table-hover">
        <thead class="thead-dark">
            <tr>
                <th>Tên Khách Hàng</th>
                <th>Số Điện Thoại</th>
                <th>Tuyến Đường</th>
                <th>Thời Gian Khởi Hành</th>
                <th>Loại Vé</th>
            </tr>
        </thead>
        <tbody>
            <tr v-for="thongtinve in filterVe" :key="thongtinve.maVe">
                <td>{{thongtinve.tenKh}}</td>
                <td>{{thongtinve.soDt}}</td>
                <td>{{thongtinve.tuyen}}</td>
                <td>{{thongtinve.thoiGian}}</td>
                <td>{{thongtinve.loaiVe}}</td>
            </tr>
        </tbody>
    </table>
  </div>
  
    </div>
</template>

<script>
import { booleanLiteral } from '@babel/types';
import axios from 'axios'
export default {
    data(){
    return{
        thongtinves:[],
        search:''
    }
 },
 created(){
        axios.get('http://localhost:5211/api/ThongTinVe')
        .then(response=>{
            console.log(response.data);
            if(response.data){
                this.thongtinves = response.data
            }
        })
        .catch(e=>{
            console.log("lỗi",e)
        })
    },
    computed: {
        filterVe:function(){
            return this.thongtinves.filter((thongtinve) => {
                return thongtinve.tenKh.match(this.search) || thongtinve.soDt.match(this.search) || thongtinve.tuyen.match(this.search) || thongtinve.thoiGian.match(this.search) || thongtinve.loaiVe.match(this.search);
            });
        }
    }
}
</script>

<style>

</style>