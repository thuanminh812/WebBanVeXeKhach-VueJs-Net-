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
              <input type="ten" class="form-control" name="ten" placeholder="Họ tên" v-model="khachhang.hoTen" required>
          </div>
          <div class="form-group">
              <input type="text" class="form-control" name="sdt" placeholder="Địa chỉ" v-model="khachhang.diaChi" required>
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
      name:'ThongTinTuyen',
   data(){
      return{
          khachhang:{
              hoTen:'',
              diaChi:''
          },
          
      }
   },
   created() {
      let name = this.$route.params.name
      if(name) {
          this.getKh(name)
      }
   },
   methods:{
      getKh(name) {
          axios.get(`http://localhost:5211/api/KhachHang/${name}`).then(response => {
              this.khachhang = response.data
          })
          
      },
      save(){ 
        if(this.khachhang.hoTen) {
          axios.put(`http://localhost:5211/api/KhachHang/${this.khachhang.hoTen}`,this.khachhang).then(response => {
              if(response.data){
                  this.$router.push({name: 'qlykh'})
                  return
              }
          })
          return;
      } 
      }
   }
  
  }
  </script>
  
  <style>
  
  </style>