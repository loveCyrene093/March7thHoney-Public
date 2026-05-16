using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetAssistHistoryScRsp : IMessage<GetAssistHistoryScRsp>, IMessage, IEquatable<GetAssistHistoryScRsp>, IDeepCloneable<GetAssistHistoryScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetAssistHistoryScRsp> _parser = new MessageParser<GetAssistHistoryScRsp>(() => new GetAssistHistoryScRsp());

	private UnknownFieldSet _unknownFields;

	public const int PLPDAACEKJBFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_pLPDAACEKJB_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> pLPDAACEKJB_ = new RepeatedField<uint>();

	public const int RetcodeFieldNumber = 7;

	private uint retcode_;

	public const int OKPBNIIDCEJFieldNumber = 9;

	private uint oKPBNIIDCEJ_;

	public const int KLEMGGNGEHGFieldNumber = 13;

	private uint kLEMGGNGEHG_;

	public const int KJIDHDCPCHHFieldNumber = 15;

	private uint kJIDHDCPCHH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetAssistHistoryScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetAssistHistoryScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> PLPDAACEKJB => pLPDAACEKJB_;

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
	public uint OKPBNIIDCEJ
	{
		get
		{
			return oKPBNIIDCEJ_;
		}
		set
		{
			oKPBNIIDCEJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KLEMGGNGEHG
	{
		get
		{
			return kLEMGGNGEHG_;
		}
		set
		{
			kLEMGGNGEHG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KJIDHDCPCHH
	{
		get
		{
			return kJIDHDCPCHH_;
		}
		set
		{
			kJIDHDCPCHH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetAssistHistoryScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetAssistHistoryScRsp(GetAssistHistoryScRsp other)
		: this()
	{
		pLPDAACEKJB_ = other.pLPDAACEKJB_.Clone();
		retcode_ = other.retcode_;
		oKPBNIIDCEJ_ = other.oKPBNIIDCEJ_;
		kLEMGGNGEHG_ = other.kLEMGGNGEHG_;
		kJIDHDCPCHH_ = other.kJIDHDCPCHH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetAssistHistoryScRsp Clone()
	{
		return new GetAssistHistoryScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetAssistHistoryScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetAssistHistoryScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!pLPDAACEKJB_.Equals(other.pLPDAACEKJB_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (OKPBNIIDCEJ != other.OKPBNIIDCEJ)
		{
			return false;
		}
		if (KLEMGGNGEHG != other.KLEMGGNGEHG)
		{
			return false;
		}
		if (KJIDHDCPCHH != other.KJIDHDCPCHH)
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
		num ^= pLPDAACEKJB_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (OKPBNIIDCEJ != 0)
		{
			num ^= OKPBNIIDCEJ.GetHashCode();
		}
		if (KLEMGGNGEHG != 0)
		{
			num ^= KLEMGGNGEHG.GetHashCode();
		}
		if (KJIDHDCPCHH != 0)
		{
			num ^= KJIDHDCPCHH.GetHashCode();
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
		pLPDAACEKJB_.WriteTo(ref output, _repeated_pLPDAACEKJB_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Retcode);
		}
		if (OKPBNIIDCEJ != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(OKPBNIIDCEJ);
		}
		if (KLEMGGNGEHG != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(KLEMGGNGEHG);
		}
		if (KJIDHDCPCHH != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(KJIDHDCPCHH);
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
		num += pLPDAACEKJB_.CalculateSize(_repeated_pLPDAACEKJB_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (OKPBNIIDCEJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OKPBNIIDCEJ);
		}
		if (KLEMGGNGEHG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KLEMGGNGEHG);
		}
		if (KJIDHDCPCHH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KJIDHDCPCHH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetAssistHistoryScRsp other)
	{
		if (other != null)
		{
			pLPDAACEKJB_.Add(other.pLPDAACEKJB_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.OKPBNIIDCEJ != 0)
			{
				OKPBNIIDCEJ = other.OKPBNIIDCEJ;
			}
			if (other.KLEMGGNGEHG != 0)
			{
				KLEMGGNGEHG = other.KLEMGGNGEHG;
			}
			if (other.KJIDHDCPCHH != 0)
			{
				KJIDHDCPCHH = other.KJIDHDCPCHH;
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
			case 8u:
			case 10u:
				pLPDAACEKJB_.AddEntriesFrom(ref input, _repeated_pLPDAACEKJB_codec);
				break;
			case 56u:
				Retcode = input.ReadUInt32();
				break;
			case 72u:
				OKPBNIIDCEJ = input.ReadUInt32();
				break;
			case 104u:
				KLEMGGNGEHG = input.ReadUInt32();
				break;
			case 120u:
				KJIDHDCPCHH = input.ReadUInt32();
				break;
			}
		}
	}
}
