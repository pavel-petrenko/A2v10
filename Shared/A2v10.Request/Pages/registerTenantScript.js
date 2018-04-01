﻿// Copyright © 2015-2018 Alex Kukhtin. All rights reserved.

(function () {


	const token = '$(Token)';

	$(Utils)
	$(Locale)

	const vm = new Vue({
		el: "#app",
		data: {
			email: '',
			name: '',
			phone: '',
			password: '',
			confirm: '',
			processing: false,
			info: $(PageData),
			submitted: false,
			serverError: '',
			emailError: '',
			showConfirm: false,
			confirmRegisterText: ''
		},
		computed: {
			locale() {
				return window.$$locale;
			},
			valid() {
				if (!this.submitted) return true;
				return this.validName &&
					this.validPassword &&
					this.validEmail &&
					this.validPhone &&
					this.validConfirm;
			},
			validName() {
				return this.submitted ? !!this.name : true;
			},
			validEmail() {
				if (!this.submitted) return true;
				if (!this.email) {
					this.emailError = this.locale.$EnterEMail;
					return false;
				} else if (!validEmail(this.email)) {
					this.emailError = this.locale.$InvalidEMail;
					return false;
				}
				this.emailError = '';
				return true;
			},
			validPassword() {
				return this.submitted ? !!this.password : true;
			},
			validConfirm() {
				return this.submitted ? !!this.confirm && (this.password === this.confirm) : true;
			},
			validPhone() {
				return this.submitted ? !!this.phone : true;
			}
		},
		methods: {
			submit() {
				this.submitted = true;
				this.serverError = '';
				if (!this.valid)
					return;
				this.processing = true;
				let dataToSend = {
					Name: this.email, // !!!!
					PersonName: this.name,
					Email: this.email,
					Phone: this.phone,
					Password: this.password
				};
				const that = this;
				post('/account/register', dataToSend)
					.then(function (response) {
						that.processing = false;
						let result = response.Status;
						if (result === 'Success')
							that.navigate();
						else if (result === 'ConfirmSent')
							that.confirmSent();
						else
							alert(result);
					})
					.catch(function (error) {
						that.processing = false;
						alert(error);
					});
			},
			navigate() {
				let qs = parseQueryString(window.location.search);
				let url = qs.ReturnUrl || '/';
				window.location.assign(url);
			},
			confirmSent() {
				this.confirmRegisterText = this.locale.$ConfirmRegister.replace('{0}', this.email);
				this.showConfirm = true;
			},
			failure(msg) {
				this.password = '';
				this.submitted = false;
				this.serverError = msg;
			},
			reload() {
				window.location.reload();
			}
		}
	});
})();