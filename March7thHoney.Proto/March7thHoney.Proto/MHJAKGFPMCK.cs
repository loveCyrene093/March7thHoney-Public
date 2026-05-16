using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MHJAKGFPMCK : IMessage<MHJAKGFPMCK>, IMessage, IEquatable<MHJAKGFPMCK>, IDeepCloneable<MHJAKGFPMCK>, IBufferMessage
{
	private static readonly MessageParser<MHJAKGFPMCK> _parser = new MessageParser<MHJAKGFPMCK>(() => new MHJAKGFPMCK());

	private UnknownFieldSet _unknownFields;

	public const int KAKCFIHMDDJFieldNumber = 1;

	private static readonly FieldCodec<string> _repeated_kAKCFIHMDDJ_codec = FieldCodec.ForString(10u);

	private readonly RepeatedField<string> kAKCFIHMDDJ_ = new RepeatedField<string>();

	public const int HKCMKEODNNBFieldNumber = 8;

	private static readonly FieldCodec<string> _repeated_hKCMKEODNNB_codec = FieldCodec.ForString(66u);

	private readonly RepeatedField<string> hKCMKEODNNB_ = new RepeatedField<string>();

	public const int RetcodeFieldNumber = 9;

	private uint retcode_;

	public const int DMCLPHFILDBFieldNumber = 14;

	private static readonly FieldCodec<string> _repeated_dMCLPHFILDB_codec = FieldCodec.ForString(114u);

	private readonly RepeatedField<string> dMCLPHFILDB_ = new RepeatedField<string>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MHJAKGFPMCK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MHJAKGFPMCKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<string> KAKCFIHMDDJ => kAKCFIHMDDJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<string> HKCMKEODNNB => hKCMKEODNNB_;

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
	public RepeatedField<string> DMCLPHFILDB => dMCLPHFILDB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MHJAKGFPMCK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MHJAKGFPMCK(MHJAKGFPMCK other)
		: this()
	{
		kAKCFIHMDDJ_ = other.kAKCFIHMDDJ_.Clone();
		hKCMKEODNNB_ = other.hKCMKEODNNB_.Clone();
		retcode_ = other.retcode_;
		dMCLPHFILDB_ = other.dMCLPHFILDB_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MHJAKGFPMCK Clone()
	{
		return new MHJAKGFPMCK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MHJAKGFPMCK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MHJAKGFPMCK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!kAKCFIHMDDJ_.Equals(other.kAKCFIHMDDJ_))
		{
			return false;
		}
		if (!hKCMKEODNNB_.Equals(other.hKCMKEODNNB_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!dMCLPHFILDB_.Equals(other.dMCLPHFILDB_))
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
		num ^= kAKCFIHMDDJ_.GetHashCode();
		num ^= hKCMKEODNNB_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= dMCLPHFILDB_.GetHashCode();
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
		kAKCFIHMDDJ_.WriteTo(ref output, _repeated_kAKCFIHMDDJ_codec);
		hKCMKEODNNB_.WriteTo(ref output, _repeated_hKCMKEODNNB_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Retcode);
		}
		dMCLPHFILDB_.WriteTo(ref output, _repeated_dMCLPHFILDB_codec);
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
		num += kAKCFIHMDDJ_.CalculateSize(_repeated_kAKCFIHMDDJ_codec);
		num += hKCMKEODNNB_.CalculateSize(_repeated_hKCMKEODNNB_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += dMCLPHFILDB_.CalculateSize(_repeated_dMCLPHFILDB_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MHJAKGFPMCK other)
	{
		if (other != null)
		{
			kAKCFIHMDDJ_.Add(other.kAKCFIHMDDJ_);
			hKCMKEODNNB_.Add(other.hKCMKEODNNB_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			dMCLPHFILDB_.Add(other.dMCLPHFILDB_);
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
			case 10u:
				kAKCFIHMDDJ_.AddEntriesFrom(ref input, _repeated_kAKCFIHMDDJ_codec);
				break;
			case 66u:
				hKCMKEODNNB_.AddEntriesFrom(ref input, _repeated_hKCMKEODNNB_codec);
				break;
			case 72u:
				Retcode = input.ReadUInt32();
				break;
			case 114u:
				dMCLPHFILDB_.AddEntriesFrom(ref input, _repeated_dMCLPHFILDB_codec);
				break;
			}
		}
	}
}
