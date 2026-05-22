using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KFCONJKHCBN : IMessage<KFCONJKHCBN>, IMessage, IEquatable<KFCONJKHCBN>, IDeepCloneable<KFCONJKHCBN>, IBufferMessage
{
	private static readonly MessageParser<KFCONJKHCBN> _parser = new MessageParser<KFCONJKHCBN>(() => new KFCONJKHCBN());

	private UnknownFieldSet _unknownFields;

	public const int OFHCNGHJFHIFieldNumber = 2;

	private uint oFHCNGHJFHI_;

	public const int GJMAPDBGEPAFieldNumber = 5;

	private static readonly FieldCodec<HJGFDIKDIHO> _repeated_gJMAPDBGEPA_codec = FieldCodec.ForMessage(42u, HJGFDIKDIHO.Parser);

	private readonly RepeatedField<HJGFDIKDIHO> gJMAPDBGEPA_ = new RepeatedField<HJGFDIKDIHO>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KFCONJKHCBN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KFCONJKHCBNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<HJGFDIKDIHO> GJMAPDBGEPA => gJMAPDBGEPA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KFCONJKHCBN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KFCONJKHCBN(KFCONJKHCBN other)
		: this()
	{
		oFHCNGHJFHI_ = other.oFHCNGHJFHI_;
		gJMAPDBGEPA_ = other.gJMAPDBGEPA_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KFCONJKHCBN Clone()
	{
		return new KFCONJKHCBN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KFCONJKHCBN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KFCONJKHCBN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OFHCNGHJFHI != other.OFHCNGHJFHI)
		{
			return false;
		}
		if (!gJMAPDBGEPA_.Equals(other.gJMAPDBGEPA_))
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
		if (OFHCNGHJFHI != 0)
		{
			num ^= OFHCNGHJFHI.GetHashCode();
		}
		num ^= gJMAPDBGEPA_.GetHashCode();
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
		if (OFHCNGHJFHI != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(OFHCNGHJFHI);
		}
		gJMAPDBGEPA_.WriteTo(ref output, _repeated_gJMAPDBGEPA_codec);
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
		if (OFHCNGHJFHI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OFHCNGHJFHI);
		}
		num += gJMAPDBGEPA_.CalculateSize(_repeated_gJMAPDBGEPA_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KFCONJKHCBN other)
	{
		if (other != null)
		{
			if (other.OFHCNGHJFHI != 0)
			{
				OFHCNGHJFHI = other.OFHCNGHJFHI;
			}
			gJMAPDBGEPA_.Add(other.gJMAPDBGEPA_);
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
				OFHCNGHJFHI = input.ReadUInt32();
				break;
			case 42u:
				gJMAPDBGEPA_.AddEntriesFrom(ref input, _repeated_gJMAPDBGEPA_codec);
				break;
			}
		}
	}
}
