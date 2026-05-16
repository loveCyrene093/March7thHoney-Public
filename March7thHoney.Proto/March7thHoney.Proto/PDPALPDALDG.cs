using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PDPALPDALDG : IMessage<PDPALPDALDG>, IMessage, IEquatable<PDPALPDALDG>, IDeepCloneable<PDPALPDALDG>, IBufferMessage
{
	private static readonly MessageParser<PDPALPDALDG> _parser = new MessageParser<PDPALPDALDG>(() => new PDPALPDALDG());

	private UnknownFieldSet _unknownFields;

	public const int UidFieldNumber = 1;

	private uint uid_;

	public const int IGGKKDPJDBEFieldNumber = 5;

	private static readonly FieldCodec<uint> _repeated_iGGKKDPJDBE_codec = FieldCodec.ForUInt32(42u);

	private readonly RepeatedField<uint> iGGKKDPJDBE_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PDPALPDALDG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PDPALPDALDGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Uid
	{
		get
		{
			return uid_;
		}
		set
		{
			uid_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IGGKKDPJDBE => iGGKKDPJDBE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PDPALPDALDG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PDPALPDALDG(PDPALPDALDG other)
		: this()
	{
		uid_ = other.uid_;
		iGGKKDPJDBE_ = other.iGGKKDPJDBE_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PDPALPDALDG Clone()
	{
		return new PDPALPDALDG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PDPALPDALDG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PDPALPDALDG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Uid != other.Uid)
		{
			return false;
		}
		if (!iGGKKDPJDBE_.Equals(other.iGGKKDPJDBE_))
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
		if (Uid != 0)
		{
			num ^= Uid.GetHashCode();
		}
		num ^= iGGKKDPJDBE_.GetHashCode();
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
		if (Uid != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Uid);
		}
		iGGKKDPJDBE_.WriteTo(ref output, _repeated_iGGKKDPJDBE_codec);
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
		if (Uid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Uid);
		}
		num += iGGKKDPJDBE_.CalculateSize(_repeated_iGGKKDPJDBE_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PDPALPDALDG other)
	{
		if (other != null)
		{
			if (other.Uid != 0)
			{
				Uid = other.Uid;
			}
			iGGKKDPJDBE_.Add(other.iGGKKDPJDBE_);
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
				Uid = input.ReadUInt32();
				break;
			case 40u:
			case 42u:
				iGGKKDPJDBE_.AddEntriesFrom(ref input, _repeated_iGGKKDPJDBE_codec);
				break;
			}
		}
	}
}
