using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TarotBookGetDataScRsp : IMessage<TarotBookGetDataScRsp>, IMessage, IEquatable<TarotBookGetDataScRsp>, IDeepCloneable<TarotBookGetDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<TarotBookGetDataScRsp> _parser = new MessageParser<TarotBookGetDataScRsp>(() => new TarotBookGetDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int FBOFMOPCMCDFieldNumber = 2;

	private uint fBOFMOPCMCD_;

	public const int CPEMLIAGBKBFieldNumber = 3;

	private CDHOKMAAMFD cPEMLIAGBKB_;

	public const int JGKCBGBGMODFieldNumber = 7;

	private uint jGKCBGBGMOD_;

	public const int JNKHOKJHBBOFieldNumber = 8;

	private GBPBMFCODPF jNKHOKJHBBO_;

	public const int RetcodeFieldNumber = 9;

	private uint retcode_;

	public const int EnergyInfoFieldNumber = 13;

	private uint energyInfo_;

	public const int CJLGPCAOPFCFieldNumber = 14;

	private static readonly MapField<uint, uint>.Codec _map_cJLGPCAOPFC_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 114u);

	private readonly MapField<uint, uint> cJLGPCAOPFC_ = new MapField<uint, uint>();

	public const int CCCKMACKLKGFieldNumber = 15;

	private static readonly MapField<uint, uint>.Codec _map_cCCKMACKLKG_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 122u);

	private readonly MapField<uint, uint> cCCKMACKLKG_ = new MapField<uint, uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TarotBookGetDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TarotBookGetDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public GBPBMFCODPF JNKHOKJHBBO
	{
		get
		{
			return jNKHOKJHBBO_;
		}
		set
		{
			jNKHOKJHBBO_ = value;
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
	public MapField<uint, uint> CJLGPCAOPFC => cJLGPCAOPFC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, uint> CCCKMACKLKG => cCCKMACKLKG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TarotBookGetDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TarotBookGetDataScRsp(TarotBookGetDataScRsp other)
		: this()
	{
		fBOFMOPCMCD_ = other.fBOFMOPCMCD_;
		cPEMLIAGBKB_ = ((other.cPEMLIAGBKB_ != null) ? other.cPEMLIAGBKB_.Clone() : null);
		jGKCBGBGMOD_ = other.jGKCBGBGMOD_;
		jNKHOKJHBBO_ = ((other.jNKHOKJHBBO_ != null) ? other.jNKHOKJHBBO_.Clone() : null);
		retcode_ = other.retcode_;
		energyInfo_ = other.energyInfo_;
		cJLGPCAOPFC_ = other.cJLGPCAOPFC_.Clone();
		cCCKMACKLKG_ = other.cCCKMACKLKG_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TarotBookGetDataScRsp Clone()
	{
		return new TarotBookGetDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TarotBookGetDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TarotBookGetDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
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
		if (!object.Equals(JNKHOKJHBBO, other.JNKHOKJHBBO))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (EnergyInfo != other.EnergyInfo)
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
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
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
		if (jNKHOKJHBBO_ != null)
		{
			num ^= JNKHOKJHBBO.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (EnergyInfo != 0)
		{
			num ^= EnergyInfo.GetHashCode();
		}
		num ^= CJLGPCAOPFC.GetHashCode();
		num ^= CCCKMACKLKG.GetHashCode();
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
		if (FBOFMOPCMCD != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(FBOFMOPCMCD);
		}
		if (cPEMLIAGBKB_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(CPEMLIAGBKB);
		}
		if (JGKCBGBGMOD != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(JGKCBGBGMOD);
		}
		if (jNKHOKJHBBO_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(JNKHOKJHBBO);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Retcode);
		}
		if (EnergyInfo != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(EnergyInfo);
		}
		cJLGPCAOPFC_.WriteTo(ref output, _map_cJLGPCAOPFC_codec);
		cCCKMACKLKG_.WriteTo(ref output, _map_cCCKMACKLKG_codec);
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
		if (jNKHOKJHBBO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JNKHOKJHBBO);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (EnergyInfo != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EnergyInfo);
		}
		num += cJLGPCAOPFC_.CalculateSize(_map_cJLGPCAOPFC_codec);
		num += cCCKMACKLKG_.CalculateSize(_map_cCCKMACKLKG_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TarotBookGetDataScRsp other)
	{
		if (other == null)
		{
			return;
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
		if (other.jNKHOKJHBBO_ != null)
		{
			if (jNKHOKJHBBO_ == null)
			{
				JNKHOKJHBBO = new GBPBMFCODPF();
			}
			JNKHOKJHBBO.MergeFrom(other.JNKHOKJHBBO);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.EnergyInfo != 0)
		{
			EnergyInfo = other.EnergyInfo;
		}
		cJLGPCAOPFC_.MergeFrom(other.cJLGPCAOPFC_);
		cCCKMACKLKG_.MergeFrom(other.cCCKMACKLKG_);
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
				FBOFMOPCMCD = input.ReadUInt32();
				break;
			case 26u:
				if (cPEMLIAGBKB_ == null)
				{
					CPEMLIAGBKB = new CDHOKMAAMFD();
				}
				input.ReadMessage(CPEMLIAGBKB);
				break;
			case 56u:
				JGKCBGBGMOD = input.ReadUInt32();
				break;
			case 66u:
				if (jNKHOKJHBBO_ == null)
				{
					JNKHOKJHBBO = new GBPBMFCODPF();
				}
				input.ReadMessage(JNKHOKJHBBO);
				break;
			case 72u:
				Retcode = input.ReadUInt32();
				break;
			case 104u:
				EnergyInfo = input.ReadUInt32();
				break;
			case 114u:
				cJLGPCAOPFC_.AddEntriesFrom(ref input, _map_cJLGPCAOPFC_codec);
				break;
			case 122u:
				cCCKMACKLKG_.AddEntriesFrom(ref input, _map_cCCKMACKLKG_codec);
				break;
			}
		}
	}
}
