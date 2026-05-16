using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ClockParkGetOngoingScriptInfoScRsp : IMessage<ClockParkGetOngoingScriptInfoScRsp>, IMessage, IEquatable<ClockParkGetOngoingScriptInfoScRsp>, IDeepCloneable<ClockParkGetOngoingScriptInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<ClockParkGetOngoingScriptInfoScRsp> _parser = new MessageParser<ClockParkGetOngoingScriptInfoScRsp>(() => new ClockParkGetOngoingScriptInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int JHFBNMENIAHFieldNumber = 1;

	private uint jHFBNMENIAH_;

	public const int ScriptIdFieldNumber = 2;

	private uint scriptId_;

	public const int FAHDMHFECMKFieldNumber = 4;

	private uint fAHDMHFECMK_;

	public const int DHOCCJMHOIFFieldNumber = 5;

	private uint dHOCCJMHOIF_;

	public const int HKGKNEKKJHBFieldNumber = 6;

	private ClockParkBuffList hKGKNEKKJHB_;

	public const int MEBMDLBPEHOFieldNumber = 7;

	private JHAKADEKJEJ mEBMDLBPEHO_;

	public const int GNJGLFOKGIDFieldNumber = 8;

	private BPNPHGLDIMI gNJGLFOKGID_;

	public const int PMLLDKHPILJFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_pMLLDKHPILJ_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> pMLLDKHPILJ_ = new RepeatedField<uint>();

	public const int MKHIJFJBOJJFieldNumber = 11;

	private string mKHIJFJBOJJ_ = "";

	public const int RetcodeFieldNumber = 12;

	private uint retcode_;

	public const int DCPKPNLKGMMFieldNumber = 13;

	private uint dCPKPNLKGMM_;

	public const int EFDMELCFIKJFieldNumber = 15;

	private uint eFDMELCFIKJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ClockParkGetOngoingScriptInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ClockParkGetOngoingScriptInfoScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JHFBNMENIAH
	{
		get
		{
			return jHFBNMENIAH_;
		}
		set
		{
			jHFBNMENIAH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ScriptId
	{
		get
		{
			return scriptId_;
		}
		set
		{
			scriptId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FAHDMHFECMK
	{
		get
		{
			return fAHDMHFECMK_;
		}
		set
		{
			fAHDMHFECMK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DHOCCJMHOIF
	{
		get
		{
			return dHOCCJMHOIF_;
		}
		set
		{
			dHOCCJMHOIF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClockParkBuffList HKGKNEKKJHB
	{
		get
		{
			return hKGKNEKKJHB_;
		}
		set
		{
			hKGKNEKKJHB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JHAKADEKJEJ MEBMDLBPEHO
	{
		get
		{
			return mEBMDLBPEHO_;
		}
		set
		{
			mEBMDLBPEHO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPNPHGLDIMI GNJGLFOKGID
	{
		get
		{
			return gNJGLFOKGID_;
		}
		set
		{
			gNJGLFOKGID_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> PMLLDKHPILJ => pMLLDKHPILJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string MKHIJFJBOJJ
	{
		get
		{
			return mKHIJFJBOJJ_;
		}
		set
		{
			mKHIJFJBOJJ_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DCPKPNLKGMM
	{
		get
		{
			return dCPKPNLKGMM_;
		}
		set
		{
			dCPKPNLKGMM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EFDMELCFIKJ
	{
		get
		{
			return eFDMELCFIKJ_;
		}
		set
		{
			eFDMELCFIKJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClockParkGetOngoingScriptInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClockParkGetOngoingScriptInfoScRsp(ClockParkGetOngoingScriptInfoScRsp other)
		: this()
	{
		jHFBNMENIAH_ = other.jHFBNMENIAH_;
		scriptId_ = other.scriptId_;
		fAHDMHFECMK_ = other.fAHDMHFECMK_;
		dHOCCJMHOIF_ = other.dHOCCJMHOIF_;
		hKGKNEKKJHB_ = ((other.hKGKNEKKJHB_ != null) ? other.hKGKNEKKJHB_.Clone() : null);
		mEBMDLBPEHO_ = ((other.mEBMDLBPEHO_ != null) ? other.mEBMDLBPEHO_.Clone() : null);
		gNJGLFOKGID_ = ((other.gNJGLFOKGID_ != null) ? other.gNJGLFOKGID_.Clone() : null);
		pMLLDKHPILJ_ = other.pMLLDKHPILJ_.Clone();
		mKHIJFJBOJJ_ = other.mKHIJFJBOJJ_;
		retcode_ = other.retcode_;
		dCPKPNLKGMM_ = other.dCPKPNLKGMM_;
		eFDMELCFIKJ_ = other.eFDMELCFIKJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClockParkGetOngoingScriptInfoScRsp Clone()
	{
		return new ClockParkGetOngoingScriptInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ClockParkGetOngoingScriptInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ClockParkGetOngoingScriptInfoScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JHFBNMENIAH != other.JHFBNMENIAH)
		{
			return false;
		}
		if (ScriptId != other.ScriptId)
		{
			return false;
		}
		if (FAHDMHFECMK != other.FAHDMHFECMK)
		{
			return false;
		}
		if (DHOCCJMHOIF != other.DHOCCJMHOIF)
		{
			return false;
		}
		if (!object.Equals(HKGKNEKKJHB, other.HKGKNEKKJHB))
		{
			return false;
		}
		if (!object.Equals(MEBMDLBPEHO, other.MEBMDLBPEHO))
		{
			return false;
		}
		if (!object.Equals(GNJGLFOKGID, other.GNJGLFOKGID))
		{
			return false;
		}
		if (!pMLLDKHPILJ_.Equals(other.pMLLDKHPILJ_))
		{
			return false;
		}
		if (MKHIJFJBOJJ != other.MKHIJFJBOJJ)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (DCPKPNLKGMM != other.DCPKPNLKGMM)
		{
			return false;
		}
		if (EFDMELCFIKJ != other.EFDMELCFIKJ)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (JHFBNMENIAH != 0)
		{
			num ^= JHFBNMENIAH.GetHashCode();
		}
		if (ScriptId != 0)
		{
			num ^= ScriptId.GetHashCode();
		}
		if (FAHDMHFECMK != 0)
		{
			num ^= FAHDMHFECMK.GetHashCode();
		}
		if (DHOCCJMHOIF != 0)
		{
			num ^= DHOCCJMHOIF.GetHashCode();
		}
		if (hKGKNEKKJHB_ != null)
		{
			num ^= HKGKNEKKJHB.GetHashCode();
		}
		if (mEBMDLBPEHO_ != null)
		{
			num ^= MEBMDLBPEHO.GetHashCode();
		}
		if (gNJGLFOKGID_ != null)
		{
			num ^= GNJGLFOKGID.GetHashCode();
		}
		num ^= pMLLDKHPILJ_.GetHashCode();
		if (MKHIJFJBOJJ.Length != 0)
		{
			num ^= MKHIJFJBOJJ.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (DCPKPNLKGMM != 0)
		{
			num ^= DCPKPNLKGMM.GetHashCode();
		}
		if (EFDMELCFIKJ != 0)
		{
			num ^= EFDMELCFIKJ.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (JHFBNMENIAH != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(JHFBNMENIAH);
		}
		if (ScriptId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(ScriptId);
		}
		if (FAHDMHFECMK != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(FAHDMHFECMK);
		}
		if (DHOCCJMHOIF != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(DHOCCJMHOIF);
		}
		if (hKGKNEKKJHB_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(HKGKNEKKJHB);
		}
		if (mEBMDLBPEHO_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(MEBMDLBPEHO);
		}
		if (gNJGLFOKGID_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(GNJGLFOKGID);
		}
		pMLLDKHPILJ_.WriteTo(ref output, _repeated_pMLLDKHPILJ_codec);
		if (MKHIJFJBOJJ.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(MKHIJFJBOJJ);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Retcode);
		}
		if (DCPKPNLKGMM != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(DCPKPNLKGMM);
		}
		if (EFDMELCFIKJ != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(EFDMELCFIKJ);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (JHFBNMENIAH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JHFBNMENIAH);
		}
		if (ScriptId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScriptId);
		}
		if (FAHDMHFECMK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FAHDMHFECMK);
		}
		if (DHOCCJMHOIF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DHOCCJMHOIF);
		}
		if (hKGKNEKKJHB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HKGKNEKKJHB);
		}
		if (mEBMDLBPEHO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MEBMDLBPEHO);
		}
		if (gNJGLFOKGID_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GNJGLFOKGID);
		}
		num += pMLLDKHPILJ_.CalculateSize(_repeated_pMLLDKHPILJ_codec);
		if (MKHIJFJBOJJ.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MKHIJFJBOJJ);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (DCPKPNLKGMM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DCPKPNLKGMM);
		}
		if (EFDMELCFIKJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EFDMELCFIKJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ClockParkGetOngoingScriptInfoScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.JHFBNMENIAH != 0)
		{
			JHFBNMENIAH = other.JHFBNMENIAH;
		}
		if (other.ScriptId != 0)
		{
			ScriptId = other.ScriptId;
		}
		if (other.FAHDMHFECMK != 0)
		{
			FAHDMHFECMK = other.FAHDMHFECMK;
		}
		if (other.DHOCCJMHOIF != 0)
		{
			DHOCCJMHOIF = other.DHOCCJMHOIF;
		}
		if (other.hKGKNEKKJHB_ != null)
		{
			if (hKGKNEKKJHB_ == null)
			{
				HKGKNEKKJHB = new ClockParkBuffList();
			}
			HKGKNEKKJHB.MergeFrom(other.HKGKNEKKJHB);
		}
		if (other.mEBMDLBPEHO_ != null)
		{
			if (mEBMDLBPEHO_ == null)
			{
				MEBMDLBPEHO = new JHAKADEKJEJ();
			}
			MEBMDLBPEHO.MergeFrom(other.MEBMDLBPEHO);
		}
		if (other.gNJGLFOKGID_ != null)
		{
			if (gNJGLFOKGID_ == null)
			{
				GNJGLFOKGID = new BPNPHGLDIMI();
			}
			GNJGLFOKGID.MergeFrom(other.GNJGLFOKGID);
		}
		pMLLDKHPILJ_.Add(other.pMLLDKHPILJ_);
		if (other.MKHIJFJBOJJ.Length != 0)
		{
			MKHIJFJBOJJ = other.MKHIJFJBOJJ;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.DCPKPNLKGMM != 0)
		{
			DCPKPNLKGMM = other.DCPKPNLKGMM;
		}
		if (other.EFDMELCFIKJ != 0)
		{
			EFDMELCFIKJ = other.EFDMELCFIKJ;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 8u:
				JHFBNMENIAH = input.ReadUInt32();
				break;
			case 16u:
				ScriptId = input.ReadUInt32();
				break;
			case 32u:
				FAHDMHFECMK = input.ReadUInt32();
				break;
			case 40u:
				DHOCCJMHOIF = input.ReadUInt32();
				break;
			case 50u:
				if (hKGKNEKKJHB_ == null)
				{
					HKGKNEKKJHB = new ClockParkBuffList();
				}
				input.ReadMessage(HKGKNEKKJHB);
				break;
			case 58u:
				if (mEBMDLBPEHO_ == null)
				{
					MEBMDLBPEHO = new JHAKADEKJEJ();
				}
				input.ReadMessage(MEBMDLBPEHO);
				break;
			case 66u:
				if (gNJGLFOKGID_ == null)
				{
					GNJGLFOKGID = new BPNPHGLDIMI();
				}
				input.ReadMessage(GNJGLFOKGID);
				break;
			case 72u:
			case 74u:
				pMLLDKHPILJ_.AddEntriesFrom(ref input, _repeated_pMLLDKHPILJ_codec);
				break;
			case 90u:
				MKHIJFJBOJJ = input.ReadString();
				break;
			case 96u:
				Retcode = input.ReadUInt32();
				break;
			case 104u:
				DCPKPNLKGMM = input.ReadUInt32();
				break;
			case 120u:
				EFDMELCFIKJ = input.ReadUInt32();
				break;
			}
		}
	}
}
