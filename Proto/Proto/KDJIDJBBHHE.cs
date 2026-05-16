using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KDJIDJBBHHE : IMessage<KDJIDJBBHHE>, IMessage, IEquatable<KDJIDJBBHHE>, IDeepCloneable<KDJIDJBBHHE>, IBufferMessage
{
	private static readonly MessageParser<KDJIDJBBHHE> _parser = new MessageParser<KDJIDJBBHHE>(() => new KDJIDJBBHHE());

	private UnknownFieldSet _unknownFields;

	public const int AreaIdFieldNumber = 3;

	private uint areaId_;

	public const int GNAAKKMMODEFieldNumber = 4;

	private static readonly FieldCodec<LFDHOPEMOPL> _repeated_gNAAKKMMODE_codec = FieldCodec.ForMessage(34u, LFDHOPEMOPL.Parser);

	private readonly RepeatedField<LFDHOPEMOPL> gNAAKKMMODE_ = new RepeatedField<LFDHOPEMOPL>();

	public const int StatusFieldNumber = 5;

	private PCDAHKGMGNB status_;

	public const int MMPBMAJEAGKFieldNumber = 6;

	private PCKIOEGAPAI mMPBMAJEAGK_;

	public const int HOKCNCMMMJGFieldNumber = 7;

	private CEFFLAGCMIL hOKCNCMMMJG_;

	public const int DJHFOKKMEAHFieldNumber = 8;

	private OEJGBJBLIEI dJHFOKKMEAH_;

	public const int PendingActionFieldNumber = 9;

	private DFAHMBOGMAN pendingAction_;

	public const int HEAMACGDPEKFieldNumber = 11;

	private static readonly FieldCodec<LNMBJPJONPE> _repeated_hEAMACGDPEK_codec = FieldCodec.ForMessage(90u, LNMBJPJONPE.Parser);

	private readonly RepeatedField<LNMBJPJONPE> hEAMACGDPEK_ = new RepeatedField<LNMBJPJONPE>();

	public const int NICNELOFHOLFieldNumber = 12;

	private uint nICNELOFHOL_;

	public const int BBLHPHFJMKFFieldNumber = 13;

	private LBCNAOFKCIL bBLHPHFJMKF_;

	public const int DifficultyLevelFieldNumber = 14;

	private uint difficultyLevel_;

	public const int JFMHILEEFCPFieldNumber = 15;

	private ANIOMKDCOEP jFMHILEEFCP_;

	public const int NOEMLPJOFAAFieldNumber = 20;

	private POFKPELNBBL nOEMLPJOFAA_;

	public const int KOKJMAEFNJPFieldNumber = 1451;

	private PKHPCMNPHKI kOKJMAEFNJP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KDJIDJBBHHE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KDJIDJBBHHEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AreaId
	{
		get
		{
			return areaId_;
		}
		set
		{
			areaId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LFDHOPEMOPL> GNAAKKMMODE => gNAAKKMMODE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PCDAHKGMGNB Status
	{
		get
		{
			return status_;
		}
		set
		{
			status_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PCKIOEGAPAI MMPBMAJEAGK
	{
		get
		{
			return mMPBMAJEAGK_;
		}
		set
		{
			mMPBMAJEAGK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CEFFLAGCMIL HOKCNCMMMJG
	{
		get
		{
			return hOKCNCMMMJG_;
		}
		set
		{
			hOKCNCMMMJG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OEJGBJBLIEI DJHFOKKMEAH
	{
		get
		{
			return dJHFOKKMEAH_;
		}
		set
		{
			dJHFOKKMEAH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DFAHMBOGMAN PendingAction
	{
		get
		{
			return pendingAction_;
		}
		set
		{
			pendingAction_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LNMBJPJONPE> HEAMACGDPEK => hEAMACGDPEK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NICNELOFHOL
	{
		get
		{
			return nICNELOFHOL_;
		}
		set
		{
			nICNELOFHOL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LBCNAOFKCIL BBLHPHFJMKF
	{
		get
		{
			return bBLHPHFJMKF_;
		}
		set
		{
			bBLHPHFJMKF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DifficultyLevel
	{
		get
		{
			return difficultyLevel_;
		}
		set
		{
			difficultyLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ANIOMKDCOEP JFMHILEEFCP
	{
		get
		{
			return jFMHILEEFCP_;
		}
		set
		{
			jFMHILEEFCP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public POFKPELNBBL NOEMLPJOFAA
	{
		get
		{
			return nOEMLPJOFAA_;
		}
		set
		{
			nOEMLPJOFAA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PKHPCMNPHKI KOKJMAEFNJP
	{
		get
		{
			return kOKJMAEFNJP_;
		}
		set
		{
			kOKJMAEFNJP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KDJIDJBBHHE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KDJIDJBBHHE(KDJIDJBBHHE other)
		: this()
	{
		areaId_ = other.areaId_;
		gNAAKKMMODE_ = other.gNAAKKMMODE_.Clone();
		status_ = other.status_;
		mMPBMAJEAGK_ = ((other.mMPBMAJEAGK_ != null) ? other.mMPBMAJEAGK_.Clone() : null);
		hOKCNCMMMJG_ = ((other.hOKCNCMMMJG_ != null) ? other.hOKCNCMMMJG_.Clone() : null);
		dJHFOKKMEAH_ = ((other.dJHFOKKMEAH_ != null) ? other.dJHFOKKMEAH_.Clone() : null);
		pendingAction_ = ((other.pendingAction_ != null) ? other.pendingAction_.Clone() : null);
		hEAMACGDPEK_ = other.hEAMACGDPEK_.Clone();
		nICNELOFHOL_ = other.nICNELOFHOL_;
		bBLHPHFJMKF_ = ((other.bBLHPHFJMKF_ != null) ? other.bBLHPHFJMKF_.Clone() : null);
		difficultyLevel_ = other.difficultyLevel_;
		jFMHILEEFCP_ = ((other.jFMHILEEFCP_ != null) ? other.jFMHILEEFCP_.Clone() : null);
		nOEMLPJOFAA_ = ((other.nOEMLPJOFAA_ != null) ? other.nOEMLPJOFAA_.Clone() : null);
		kOKJMAEFNJP_ = ((other.kOKJMAEFNJP_ != null) ? other.kOKJMAEFNJP_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KDJIDJBBHHE Clone()
	{
		return new KDJIDJBBHHE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KDJIDJBBHHE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KDJIDJBBHHE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AreaId != other.AreaId)
		{
			return false;
		}
		if (!gNAAKKMMODE_.Equals(other.gNAAKKMMODE_))
		{
			return false;
		}
		if (Status != other.Status)
		{
			return false;
		}
		if (!object.Equals(MMPBMAJEAGK, other.MMPBMAJEAGK))
		{
			return false;
		}
		if (!object.Equals(HOKCNCMMMJG, other.HOKCNCMMMJG))
		{
			return false;
		}
		if (!object.Equals(DJHFOKKMEAH, other.DJHFOKKMEAH))
		{
			return false;
		}
		if (!object.Equals(PendingAction, other.PendingAction))
		{
			return false;
		}
		if (!hEAMACGDPEK_.Equals(other.hEAMACGDPEK_))
		{
			return false;
		}
		if (NICNELOFHOL != other.NICNELOFHOL)
		{
			return false;
		}
		if (!object.Equals(BBLHPHFJMKF, other.BBLHPHFJMKF))
		{
			return false;
		}
		if (DifficultyLevel != other.DifficultyLevel)
		{
			return false;
		}
		if (!object.Equals(JFMHILEEFCP, other.JFMHILEEFCP))
		{
			return false;
		}
		if (!object.Equals(NOEMLPJOFAA, other.NOEMLPJOFAA))
		{
			return false;
		}
		if (!object.Equals(KOKJMAEFNJP, other.KOKJMAEFNJP))
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
		if (AreaId != 0)
		{
			num ^= AreaId.GetHashCode();
		}
		num ^= gNAAKKMMODE_.GetHashCode();
		if (Status != PCDAHKGMGNB.Pcpdhelpkem)
		{
			num ^= Status.GetHashCode();
		}
		if (mMPBMAJEAGK_ != null)
		{
			num ^= MMPBMAJEAGK.GetHashCode();
		}
		if (hOKCNCMMMJG_ != null)
		{
			num ^= HOKCNCMMMJG.GetHashCode();
		}
		if (dJHFOKKMEAH_ != null)
		{
			num ^= DJHFOKKMEAH.GetHashCode();
		}
		if (pendingAction_ != null)
		{
			num ^= PendingAction.GetHashCode();
		}
		num ^= hEAMACGDPEK_.GetHashCode();
		if (NICNELOFHOL != 0)
		{
			num ^= NICNELOFHOL.GetHashCode();
		}
		if (bBLHPHFJMKF_ != null)
		{
			num ^= BBLHPHFJMKF.GetHashCode();
		}
		if (DifficultyLevel != 0)
		{
			num ^= DifficultyLevel.GetHashCode();
		}
		if (jFMHILEEFCP_ != null)
		{
			num ^= JFMHILEEFCP.GetHashCode();
		}
		if (nOEMLPJOFAA_ != null)
		{
			num ^= NOEMLPJOFAA.GetHashCode();
		}
		if (kOKJMAEFNJP_ != null)
		{
			num ^= KOKJMAEFNJP.GetHashCode();
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
		if (AreaId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(AreaId);
		}
		gNAAKKMMODE_.WriteTo(ref output, _repeated_gNAAKKMMODE_codec);
		if (Status != PCDAHKGMGNB.Pcpdhelpkem)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)Status);
		}
		if (mMPBMAJEAGK_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(MMPBMAJEAGK);
		}
		if (hOKCNCMMMJG_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(HOKCNCMMMJG);
		}
		if (dJHFOKKMEAH_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(DJHFOKKMEAH);
		}
		if (pendingAction_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(PendingAction);
		}
		hEAMACGDPEK_.WriteTo(ref output, _repeated_hEAMACGDPEK_codec);
		if (NICNELOFHOL != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(NICNELOFHOL);
		}
		if (bBLHPHFJMKF_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(BBLHPHFJMKF);
		}
		if (DifficultyLevel != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(DifficultyLevel);
		}
		if (jFMHILEEFCP_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(JFMHILEEFCP);
		}
		if (nOEMLPJOFAA_ != null)
		{
			output.WriteRawTag(162, 1);
			output.WriteMessage(NOEMLPJOFAA);
		}
		if (kOKJMAEFNJP_ != null)
		{
			output.WriteRawTag(218, 90);
			output.WriteMessage(KOKJMAEFNJP);
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
		if (AreaId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AreaId);
		}
		num += gNAAKKMMODE_.CalculateSize(_repeated_gNAAKKMMODE_codec);
		if (Status != PCDAHKGMGNB.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Status);
		}
		if (mMPBMAJEAGK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MMPBMAJEAGK);
		}
		if (hOKCNCMMMJG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HOKCNCMMMJG);
		}
		if (dJHFOKKMEAH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DJHFOKKMEAH);
		}
		if (pendingAction_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PendingAction);
		}
		num += hEAMACGDPEK_.CalculateSize(_repeated_hEAMACGDPEK_codec);
		if (NICNELOFHOL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NICNELOFHOL);
		}
		if (bBLHPHFJMKF_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BBLHPHFJMKF);
		}
		if (DifficultyLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DifficultyLevel);
		}
		if (jFMHILEEFCP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JFMHILEEFCP);
		}
		if (nOEMLPJOFAA_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(NOEMLPJOFAA);
		}
		if (kOKJMAEFNJP_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(KOKJMAEFNJP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KDJIDJBBHHE other)
	{
		if (other == null)
		{
			return;
		}
		if (other.AreaId != 0)
		{
			AreaId = other.AreaId;
		}
		gNAAKKMMODE_.Add(other.gNAAKKMMODE_);
		if (other.Status != PCDAHKGMGNB.Pcpdhelpkem)
		{
			Status = other.Status;
		}
		if (other.mMPBMAJEAGK_ != null)
		{
			if (mMPBMAJEAGK_ == null)
			{
				MMPBMAJEAGK = new PCKIOEGAPAI();
			}
			MMPBMAJEAGK.MergeFrom(other.MMPBMAJEAGK);
		}
		if (other.hOKCNCMMMJG_ != null)
		{
			if (hOKCNCMMMJG_ == null)
			{
				HOKCNCMMMJG = new CEFFLAGCMIL();
			}
			HOKCNCMMMJG.MergeFrom(other.HOKCNCMMMJG);
		}
		if (other.dJHFOKKMEAH_ != null)
		{
			if (dJHFOKKMEAH_ == null)
			{
				DJHFOKKMEAH = new OEJGBJBLIEI();
			}
			DJHFOKKMEAH.MergeFrom(other.DJHFOKKMEAH);
		}
		if (other.pendingAction_ != null)
		{
			if (pendingAction_ == null)
			{
				PendingAction = new DFAHMBOGMAN();
			}
			PendingAction.MergeFrom(other.PendingAction);
		}
		hEAMACGDPEK_.Add(other.hEAMACGDPEK_);
		if (other.NICNELOFHOL != 0)
		{
			NICNELOFHOL = other.NICNELOFHOL;
		}
		if (other.bBLHPHFJMKF_ != null)
		{
			if (bBLHPHFJMKF_ == null)
			{
				BBLHPHFJMKF = new LBCNAOFKCIL();
			}
			BBLHPHFJMKF.MergeFrom(other.BBLHPHFJMKF);
		}
		if (other.DifficultyLevel != 0)
		{
			DifficultyLevel = other.DifficultyLevel;
		}
		if (other.jFMHILEEFCP_ != null)
		{
			if (jFMHILEEFCP_ == null)
			{
				JFMHILEEFCP = new ANIOMKDCOEP();
			}
			JFMHILEEFCP.MergeFrom(other.JFMHILEEFCP);
		}
		if (other.nOEMLPJOFAA_ != null)
		{
			if (nOEMLPJOFAA_ == null)
			{
				NOEMLPJOFAA = new POFKPELNBBL();
			}
			NOEMLPJOFAA.MergeFrom(other.NOEMLPJOFAA);
		}
		if (other.kOKJMAEFNJP_ != null)
		{
			if (kOKJMAEFNJP_ == null)
			{
				KOKJMAEFNJP = new PKHPCMNPHKI();
			}
			KOKJMAEFNJP.MergeFrom(other.KOKJMAEFNJP);
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
			case 24u:
				AreaId = input.ReadUInt32();
				break;
			case 34u:
				gNAAKKMMODE_.AddEntriesFrom(ref input, _repeated_gNAAKKMMODE_codec);
				break;
			case 40u:
				Status = (PCDAHKGMGNB)input.ReadEnum();
				break;
			case 50u:
				if (mMPBMAJEAGK_ == null)
				{
					MMPBMAJEAGK = new PCKIOEGAPAI();
				}
				input.ReadMessage(MMPBMAJEAGK);
				break;
			case 58u:
				if (hOKCNCMMMJG_ == null)
				{
					HOKCNCMMMJG = new CEFFLAGCMIL();
				}
				input.ReadMessage(HOKCNCMMMJG);
				break;
			case 66u:
				if (dJHFOKKMEAH_ == null)
				{
					DJHFOKKMEAH = new OEJGBJBLIEI();
				}
				input.ReadMessage(DJHFOKKMEAH);
				break;
			case 74u:
				if (pendingAction_ == null)
				{
					PendingAction = new DFAHMBOGMAN();
				}
				input.ReadMessage(PendingAction);
				break;
			case 90u:
				hEAMACGDPEK_.AddEntriesFrom(ref input, _repeated_hEAMACGDPEK_codec);
				break;
			case 96u:
				NICNELOFHOL = input.ReadUInt32();
				break;
			case 106u:
				if (bBLHPHFJMKF_ == null)
				{
					BBLHPHFJMKF = new LBCNAOFKCIL();
				}
				input.ReadMessage(BBLHPHFJMKF);
				break;
			case 112u:
				DifficultyLevel = input.ReadUInt32();
				break;
			case 122u:
				if (jFMHILEEFCP_ == null)
				{
					JFMHILEEFCP = new ANIOMKDCOEP();
				}
				input.ReadMessage(JFMHILEEFCP);
				break;
			case 162u:
				if (nOEMLPJOFAA_ == null)
				{
					NOEMLPJOFAA = new POFKPELNBBL();
				}
				input.ReadMessage(NOEMLPJOFAA);
				break;
			case 11610u:
				if (kOKJMAEFNJP_ == null)
				{
					KOKJMAEFNJP = new PKHPCMNPHKI();
				}
				input.ReadMessage(KOKJMAEFNJP);
				break;
			}
		}
	}
}
