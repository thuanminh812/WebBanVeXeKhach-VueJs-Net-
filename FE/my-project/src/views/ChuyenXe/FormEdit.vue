<template>
    <div style="margin-top: -60px">
      <section id="sidebar">
          <a href="#" class="brand">
              <i class='bx bxs-smile'></i>
              <span class="text">Admin</span>
          </a>
          <ul class="side-menu top">
              
              <li>
                  <a href="qly">
                      <i class='bx bxs-shopping-bag-alt' ></i>
                      <span class="text">Quản lý vé xe</span>
                  </a>
              </li>
              <li>
                  <a href="qlytuyen">
                      <i class='bx bxs-doughnut-chart' ></i>
                      <span class="text">Quản lý tuyến xe</span>
                  </a>
              </li>
              <li>
                  <a href="qlychuyen">
                      <i class='bx bxs-message-dots' ></i>
                      <span class="text">Quản lý chuyến xe</span>
                  </a>
              </li>
              <li>
                  <a href="qlykh">
                      <i class='bx bxs-group' ></i>
                      <span class="text">Quản lý khách hàng</span>
                  </a>
              </li>
          </ul>
          <ul class="side-menu">
              <li>
                  <a href="#">
                      <i class='bx bxs-cog' ></i>
                      <span class="text">Cài đặt</span>
                  </a>
              </li>
              <li>
                  <a href="page" class="logout">
                      <i class='bx bxs-log-out-circle' ></i>
                      <span class="text">Đăng xuất</span>
                  </a>
              </li>
          </ul>
      </section>
      <section id="content">
          <nav>
              <i class='bx bx-menu' ></i>
              <a href="#" class="nav-link">Danh mục</a>
              <form action="#">
                  <div class="form-input">
                      <input type="search" placeholder="Search...">
                      <button type="submit" class="search-btn"><i class='bx bx-search' ></i></button>
                  </div>
              </form>
              <a href="#" class="notification">
                  <i class='bx bxs-bell' ></i>
                  <span class="num">8</span>
              </a>
          </nav>
          </section>
          <form @submit.prevent="save()"  action="" class=" border mt-4 p-4 " style="width: 800px; margin-left: 500px;">
              <h4 class="text-info">Nhập thông tin</h4>
          <div class="form-group">
              <input type="text" class="form-control" name="abc" placeholder="Mã chuyến" v-model="thongtinchuyen.maChuyen" required>
          </div>
  		<div class="form-group">
			<select name="tuyen" class="form-control" id="" v-model="thongtinchuyen.tuyen" required>
				<option value="">Tuyến xe</option>
                <option v-for="thongtintuyen in thongtintuyens" :key="thongtintuyen.tuyen">{{ thongtintuyen.tuyen }}</option>
            </select>
		</div>
          <div class="form-group">
              <input placeholder="Trạng thái"  class="form-control" name="ngay" v-model="thongtinchuyen.trangThai" required>
          </div>
          <div id = "datve">
          <button type="submit" class="btn btn-success">Lưu</button> &nbsp;
          </div>
          </form>
    </div>
  </template>
  
  <script>
  import axios from 'axios'
  export default {
      name:'ThongTinChuyen',
   data(){
      return{
        thongtintuyens:[],
          thongtinchuyen:{
              maChuyen:'',
              tuyen:'',
              trangThai:''
          },
          
      }
   },
   created() {
      let name = this.$route.params.name
      if(name) {
          this.getChuyenXe(name)
      }
   },
   methods:{
      getChuyenXe(name) {
          axios.get(`http://localhost:5211/api/ThongTinChuyen/${name}`).then(response => {
              this.thongtinchuyen = response.data
          })
          
      },
      save(){
          if(this.thongtinchuyen.maChuyen) {
          axios.put(`http://localhost:5211/api/ThongTinChuyen/${this.thongtinchuyen.maChuyen}`,this.thongtinchuyen).then(response => {
              if(response.data){
                  this.$router.push({name: 'qlychuyen'})
                  return
              }
          })
          return;
      } 
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
  
  </style>