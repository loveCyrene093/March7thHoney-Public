using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TarotBookMultiOpenPackAndUnlockStoryScRsp : IMessage<TarotBookMultiOpenPackAndUnlockStoryScRsp>, IMessage, IEquatable<TarotBookMultiOpenPackAndUnlockStoryScRsp>, IDeepCloneable<TarotBookMultiOpenPackAndUnlockStoryScRsp>, IBufferMessage
{
	private static readonly MessageParser<TarotBookMultiOpenPackAndUnlockStoryScRsp> _parser = new MessageParser<TarotBookMultiOpenPackAndUnlockStoryScRsp>(() => new TarotBookMultiOpenPackAndUnlockStoryScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 2;

	private uint retcode_;

	public const int FBOFMOPCMCDFieldNumber = 3;

	private uint fBOFMOPCMCD_;

	public const int CPEMLIAGBKBFieldNumber = 4;

	private CDHOKMAAMFD cPEMLIAGBKB_;

	public const int JGKCBGBGMODFieldNumber = 6;

	private uint jGKCBGBGMOD_;

	public const int CJLGPCAOPFCFieldNumber = 8;

	private static readonly MapField<uint, uint>.Codec _map_cJLGPCAOPFC_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 66u);

	private readonly MapField<uint, uint> cJLGPCAOPFC_ = new MapField<uint, uint>();

	public const int CCCKMACKLKGFieldNumber = 9;

	private static readonly MapField<uint, uint>.Codec _map_cCCKMACKLKG_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 74u);

	private readonly MapField<uint, uint> cCCKMACKLKG_ = new MapField<uint, uint>();

	public const int EnergyInfoFieldNumber = 12;

	private uint energyInfo_;

	public const int MMKNNLDLDHIFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_mMKNNLDLDHI_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> mMKNNLDLDHI_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TarotBookMultiOpenPackAndUnlockStoryScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TarotBookMultiOpenPackAndUnlockStoryScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint FBOFMOPCMCD
	{
		get
		{
			return fBOFMOPCMCD_;
		}
		set
		{
			fBOFMOPCMCD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CDHOKMAAMFD CPEMLIAGBKB
	{
		get
		{
			return cPEMLIAGBKB_;
		}
		set
		{
			cPEMLIAGBKB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JGKCBGBGMOD
	{
		get
		{
			return jGKCBGBGMOD_;
		}
		set
		{
			jGKCBGBGMOD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, uint> CJLGPCAOPFC => cJLGPCAOPFC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, uint> CCCKMACKLKG => cCCKMACKLKG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EnergyInfo
	{
		get
		{
			return energyInfo_;
		}
		set
		{
			energyInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> MMKNNLDLDHI => mMKNNLDLDHI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TarotBookMultiOpenPackAndUnlockStoryScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TarotBookMultiOpenPackAndUnlockStoryScRsp(TarotBookMultiOpenPackAndUnlockStoryScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		fBOFMOPCMCD_ = other.fBOFMOPCMCD_;
		cPEMLIAGBKB_ = ((other.cPEMLIAGBKB_ != null) ? other.cPEMLIAGBKB_.Clone() : null);
		jGKCBGBGMOD_ = other.jGKCBGBGMOD_;
		cJLGPCAOPFC_ = other.cJLGPCAOPFC_.Clone();
		cCCKMACKLKG_ = other.cCCKMACKLKG_.Clone();
		energyInfo_ = other.energyInfo_;
		mMKNNLDLDHI_ = other.mMKNNLDLDHI_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TarotBookMultiOpenPackAndUnlockStoryScRsp Clone()
	{
		return new TarotBookMultiOpenPackAndUnlockStoryScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TarotBookMultiOpenPackAndUnlockStoryScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TarotBookMultiOpenPackAndUnlockStoryScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (FBOFMOPCMCD != other.FBOFMOPCMCD)
		{
			return false;
		}
		if (!object.Equals(CPEMLIAGBKB, other.CPEMLIAGBKB))
		{
			return false;
		}
		if (JGKCBGBGMOD != other.JGKCBGBGMOD)
		{
			return false;
		}
		if (!CJLGPCAOPFC.Equals(other.CJLGPCAOPFC))
		{
			return false;
		}
		if (!CCCKMACKLKG.Equals(other.CCCKMACKLKG))
		{
			return false;
		}
		if (EnergyInfo != other.EnergyInfo)
		{
			return false;
		}
		if (!mMKNNLDLDHI_.Equals(other.mMKNNLDLDHI_))
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (FBOFMOPCMCD != 0)
		{
			num ^= FBOFMOPCMCD.GetHashCode();
		}
		if (cPEMLIAGBKB_ != null)
		{
			num ^= CPEMLIAGBKB.GetHashCode();
		}
		if (JGKCBGBGMOD != 0)
		{
			num ^= JGKCBGBGMOD.GetHashCode();
		}
		num ^= CJLGPCAOPFC.GetHashCode();
		num ^= CCCKMACKLKG.GetHashCode();
		if (EnergyInfo != 0)
		{
			num ^= EnergyInfo.GetHashCode();
		}
		num ^= mMKNNLDLDHI_.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Retcode);
		}
		if (FBOFMOPCMCD != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(FBOFMOPCMCD);
		}
		if (cPEMLIAGBKB_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(CPEMLIAGBKB);
		}
		if (JGKCBGBGMOD != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(JGKCBGBGMOD);
		}
		cJLGPCAOPFC_.WriteTo(ref output, _map_cJLGPCAOPFC_codec);
		cCCKMACKLKG_.WriteTo(ref output, _map_cCCKMACKLKG_codec);
		if (EnergyInfo != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(EnergyInfo);
		}
		mMKNNLDLDHI_.WriteTo(ref output, _repeated_mMKNNLDLDHI_codec);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (FBOFMOPCMCD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FBOFMOPCMCD);
		}
		if (cPEMLIAGBKB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CPEMLIAGBKB);
		}
		if (JGKCBGBGMOD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JGKCBGBGMOD);
		}
		num += cJLGPCAOPFC_.CalculateSize(_map_cJLGPCAOPFC_codec);
		num += cCCKMACKLKG_.CalculateSize(_map_cCCKMACKLKG_codec);
		if (EnergyInfo != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EnergyInfo);
		}
		num += mMKNNLDLDHI_.CalculateSize(_repeated_mMKNNLDLDHI_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TarotBookMultiOpenPackAndUnlockStoryScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.FBOFMOPCMCD != 0)
		{
			FBOFMOPCMCD = other.FBOFMOPCMCD;
		}
		if (other.cPEMLIAGBKB_ != null)
		{
			if (cPEMLIAGBKB_ == null)
			{
				CPEMLIAGBKB = new CDHOKMAAMFD();
			}
			CPEMLIAGBKB.MergeFrom(other.CPEMLIAGBKB);
		}
		if (other.JGKCBGBGMOD != 0)
		{
			JGKCBGBGMOD = other.JGKCBGBGMOD;
		}
		cJLGPCAOPFC_.MergeFrom(other.cJLGPCAOPFC_);
		cCCKMACKLKG_.MergeFrom(other.cCCKMACKLKG_);
		if (other.EnergyInfo != 0)
		{
			EnergyInfo = other.EnergyInfo;
		}
		mMKNNLDLDHI_.Add(other.mMKNNLDLDHI_);
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
			case 16u:
				Retcode = input.ReadUInt32();
				break;
			case 24u:
				FBOFMOPCMCD = input.ReadUInt32();
				break;
			case 34u:
				if (cPEMLIAGBKB_ == null)
				{
					CPEMLIAGBKB = new CDHOKMAAMFD();
				}
				input.ReadMessage(CPEMLIAGBKB);
				break;
			case 48u:
				JGKCBGBGMOD = input.ReadUInt32();
				break;
			case 66u:
				cJLGPCAOPFC_.AddEntriesFrom(ref input, _map_cJLGPCAOPFC_codec);
				break;
			case 74u:
				cCCKMACKLKG_.AddEntriesFrom(ref input, _map_cCCKMACKLKG_codec);
				break;
			case 96u:
				EnergyInfo = input.ReadUInt32();
				break;
			case 104u:
			case 106u:
				mMKNNLDLDHI_.AddEntriesFrom(ref input, _repeated_mMKNNLDLDHI_codec);
				break;
			}
		}
	}
}
