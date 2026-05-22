using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LEDDFOGLMJD : IMessage<LEDDFOGLMJD>, IMessage, IEquatable<LEDDFOGLMJD>, IDeepCloneable<LEDDFOGLMJD>, IBufferMessage
{
	private static readonly MessageParser<LEDDFOGLMJD> _parser = new MessageParser<LEDDFOGLMJD>(() => new LEDDFOGLMJD());

	private UnknownFieldSet _unknownFields;

	public const int BAPDFFEDAHMFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_bAPDFFEDAHM_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> bAPDFFEDAHM_ = new RepeatedField<uint>();

	public const int OFHCNGHJFHIFieldNumber = 4;

	private uint oFHCNGHJFHI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LEDDFOGLMJD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LEDDFOGLMJDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> BAPDFFEDAHM => bAPDFFEDAHM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OFHCNGHJFHI
	{
		get
		{
			return oFHCNGHJFHI_;
		}
		set
		{
			oFHCNGHJFHI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LEDDFOGLMJD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LEDDFOGLMJD(LEDDFOGLMJD other)
		: this()
	{
		bAPDFFEDAHM_ = other.bAPDFFEDAHM_.Clone();
		oFHCNGHJFHI_ = other.oFHCNGHJFHI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LEDDFOGLMJD Clone()
	{
		return new LEDDFOGLMJD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LEDDFOGLMJD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LEDDFOGLMJD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!bAPDFFEDAHM_.Equals(other.bAPDFFEDAHM_))
		{
			return false;
		}
		if (OFHCNGHJFHI != other.OFHCNGHJFHI)
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
		num ^= bAPDFFEDAHM_.GetHashCode();
		if (OFHCNGHJFHI != 0)
		{
			num ^= OFHCNGHJFHI.GetHashCode();
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
		bAPDFFEDAHM_.WriteTo(ref output, _repeated_bAPDFFEDAHM_codec);
		if (OFHCNGHJFHI != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(OFHCNGHJFHI);
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
		num += bAPDFFEDAHM_.CalculateSize(_repeated_bAPDFFEDAHM_codec);
		if (OFHCNGHJFHI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OFHCNGHJFHI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LEDDFOGLMJD other)
	{
		if (other != null)
		{
			bAPDFFEDAHM_.Add(other.bAPDFFEDAHM_);
			if (other.OFHCNGHJFHI != 0)
			{
				OFHCNGHJFHI = other.OFHCNGHJFHI;
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
			case 18u:
				bAPDFFEDAHM_.AddEntriesFrom(ref input, _repeated_bAPDFFEDAHM_codec);
				break;
			case 32u:
				OFHCNGHJFHI = input.ReadUInt32();
				break;
			}
		}
	}
}
