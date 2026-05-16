using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TarotBookOpenPackScRsp : IMessage<TarotBookOpenPackScRsp>, IMessage, IEquatable<TarotBookOpenPackScRsp>, IDeepCloneable<TarotBookOpenPackScRsp>, IBufferMessage
{
	private static readonly MessageParser<TarotBookOpenPackScRsp> _parser = new MessageParser<TarotBookOpenPackScRsp>(() => new TarotBookOpenPackScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 2;

	private uint retcode_;

	public const int EnergyInfoFieldNumber = 5;

	private uint energyInfo_;

	public const int EKJFDJCHKLMFieldNumber = 6;

	private static readonly MapField<uint, uint>.Codec _map_eKJFDJCHKLM_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 50u);

	private readonly MapField<uint, uint> eKJFDJCHKLM_ = new MapField<uint, uint>();

	public const int FBOFMOPCMCDFieldNumber = 8;

	private uint fBOFMOPCMCD_;

	public const int FCINHMNNOGKFieldNumber = 13;

	private static readonly MapField<uint, uint>.Codec _map_fCINHMNNOGK_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 106u);

	private readonly MapField<uint, uint> fCINHMNNOGK_ = new MapField<uint, uint>();

	public const int JGKCBGBGMODFieldNumber = 14;

	private uint jGKCBGBGMOD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TarotBookOpenPackScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TarotBookOpenPackScRspReflection.Descriptor.MessageTypes[0];

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
	public MapField<uint, uint> EKJFDJCHKLM => eKJFDJCHKLM_;

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
	public MapField<uint, uint> FCINHMNNOGK => fCINHMNNOGK_;

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
	public TarotBookOpenPackScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TarotBookOpenPackScRsp(TarotBookOpenPackScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		energyInfo_ = other.energyInfo_;
		eKJFDJCHKLM_ = other.eKJFDJCHKLM_.Clone();
		fBOFMOPCMCD_ = other.fBOFMOPCMCD_;
		fCINHMNNOGK_ = other.fCINHMNNOGK_.Clone();
		jGKCBGBGMOD_ = other.jGKCBGBGMOD_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TarotBookOpenPackScRsp Clone()
	{
		return new TarotBookOpenPackScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TarotBookOpenPackScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TarotBookOpenPackScRsp other)
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
		if (EnergyInfo != other.EnergyInfo)
		{
			return false;
		}
		if (!EKJFDJCHKLM.Equals(other.EKJFDJCHKLM))
		{
			return false;
		}
		if (FBOFMOPCMCD != other.FBOFMOPCMCD)
		{
			return false;
		}
		if (!FCINHMNNOGK.Equals(other.FCINHMNNOGK))
		{
			return false;
		}
		if (JGKCBGBGMOD != other.JGKCBGBGMOD)
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
		if (EnergyInfo != 0)
		{
			num ^= EnergyInfo.GetHashCode();
		}
		num ^= EKJFDJCHKLM.GetHashCode();
		if (FBOFMOPCMCD != 0)
		{
			num ^= FBOFMOPCMCD.GetHashCode();
		}
		num ^= FCINHMNNOGK.GetHashCode();
		if (JGKCBGBGMOD != 0)
		{
			num ^= JGKCBGBGMOD.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Retcode);
		}
		if (EnergyInfo != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(EnergyInfo);
		}
		eKJFDJCHKLM_.WriteTo(ref output, _map_eKJFDJCHKLM_codec);
		if (FBOFMOPCMCD != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(FBOFMOPCMCD);
		}
		fCINHMNNOGK_.WriteTo(ref output, _map_fCINHMNNOGK_codec);
		if (JGKCBGBGMOD != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(JGKCBGBGMOD);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (EnergyInfo != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EnergyInfo);
		}
		num += eKJFDJCHKLM_.CalculateSize(_map_eKJFDJCHKLM_codec);
		if (FBOFMOPCMCD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FBOFMOPCMCD);
		}
		num += fCINHMNNOGK_.CalculateSize(_map_fCINHMNNOGK_codec);
		if (JGKCBGBGMOD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JGKCBGBGMOD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TarotBookOpenPackScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.EnergyInfo != 0)
			{
				EnergyInfo = other.EnergyInfo;
			}
			eKJFDJCHKLM_.MergeFrom(other.eKJFDJCHKLM_);
			if (other.FBOFMOPCMCD != 0)
			{
				FBOFMOPCMCD = other.FBOFMOPCMCD;
			}
			fCINHMNNOGK_.MergeFrom(other.fCINHMNNOGK_);
			if (other.JGKCBGBGMOD != 0)
			{
				JGKCBGBGMOD = other.JGKCBGBGMOD;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
			case 40u:
				EnergyInfo = input.ReadUInt32();
				break;
			case 50u:
				eKJFDJCHKLM_.AddEntriesFrom(ref input, _map_eKJFDJCHKLM_codec);
				break;
			case 64u:
				FBOFMOPCMCD = input.ReadUInt32();
				break;
			case 106u:
				fCINHMNNOGK_.AddEntriesFrom(ref input, _map_fCINHMNNOGK_codec);
				break;
			case 112u:
				JGKCBGBGMOD = input.ReadUInt32();
				break;
			}
		}
	}
}
