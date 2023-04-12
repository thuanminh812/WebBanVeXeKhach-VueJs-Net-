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
        <br>
        <marquee style="width:800px;font-size:20px;" class="container" behavior="" direction="">VeXeRe.com - Sàn TMĐT về vé xe lớn nhất Việt Nam, hỗ trợ người dùng đặt vé xe khách một cách dễ dàng, tiện lợi và nhanh chóng. Dùng mã ngay để nhận ưu đãi đến 25% cho đơn hàng đầu tiên của bạn tại VeXeRe nhé!

Đối tượng áp dụng: Áp dụng cho khách hàng lần đầu đặt vé tại VeXeRe.
Thời gian áp dụng: Áp dụng cho ngày khởi hành đến hết 28/12/2022.</marquee>
<br>

        <h3 class="text-danger">Thông Tin Các Chuyến Xe:</h3>
        <br>
    <table class="table table table-bordered table-striped table-hover">
        <thead class="thead-dark">
            <tr>
                <th>Mã chuyến</th>
                <th>Điểm bắt đầu - Kết thúc</th>
                <th>Trạng thái</th>
            </tr>
        </thead>
        <tbody>
            <tr v-for="thongtinchuyen in filterChuyen" v-bind:key="thongtinchuyen.maChuyen">
                <td>{{thongtinchuyen.maChuyen}}</td>
                <td>{{thongtinchuyen.tuyen}}</td>
                <td>{{thongtinchuyen.trangThai}}</td>
            </tr>
        </tbody>
    </table>
  </div>
    </div>
</template>

<script>
import axios from 'axios'
export default {
    name:'ThongTinVe',
    data(){
    return{
        thongtinchuyens: [],
        search:'',
        thongtinchuyen:{
            maChuyen:'',
            tuyen:'',
			trangthai:''
        }
    }
 },
 created(){
        axios.get('http://localhost:5211/api/ThongTinChuyen')
        .then(response=>{
            if(response.data){
                this.thongtinchuyens = response.data
            }
        })
        .catch(e=>{
            console.log("lỗi",e)
        })
    },
    computed: {
        filterChuyen:function(){
            return this.thongtinchuyens.filter((thongtinchuyen) => {
                return thongtinchuyen.maChuyen.match(this.search) || thongtinchuyen.tuyen.match(this.search) || thongtinchuyen.trangThai.match(this.search);
            });
        }
    }
}
</script>

<style>

</style>