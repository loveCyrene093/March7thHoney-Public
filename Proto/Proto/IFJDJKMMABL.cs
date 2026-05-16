using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IFJDJKMMABL : IMessage<IFJDJKMMABL>, IMessage, IEquatable<IFJDJKMMABL>, IDeepCloneable<IFJDJKMMABL>, IBufferMessage
{
	private static readonly MessageParser<IFJDJKMMABL> _parser = new MessageParser<IFJDJKMMABL>(() => new IFJDJKMMABL());

	private UnknownFieldSet _unknownFields;

	public const int IOJKDGCFCGGFieldNumber = 3;

	private uint iOJKDGCFCGG_;

	public const int NLOINMODBLEFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_nLOINMODBLE_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> nLOINMODBLE_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IFJDJKMMABL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IFJDJKMMABLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IOJKDGCFCGG
	{
		get
		{
			return iOJKDGCFCGG_;
		}
		set
		{
			iOJKDGCFCGG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> NLOINMODBLE => nLOINMODBLE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFJDJKMMABL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFJDJKMMABL(IFJDJKMMABL other)
		: this()
	{
		iOJKDGCFCGG_ = other.iOJKDGCFCGG_;
		nLOINMODBLE_ = other.nLOINMODBLE_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFJDJKMMABL Clone()
	{
		return new IFJDJKMMABL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IFJDJKMMABL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IFJDJKMMABL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IOJKDGCFCGG != other.IOJKDGCFCGG)
		{
			return false;
		}
		if (!nLOINMODBLE_.Equals(other.nLOINMODBLE_))
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
		if (IOJKDGCFCGG != 0)
		{
			num ^= IOJKDGCFCGG.GetHashCode();
		}
		num ^= nLOINMODBLE_.GetHashCode();
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
		if (IOJKDGCFCGG != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(IOJKDGCFCGG);
		}
		nLOINMODBLE_.WriteTo(ref output, _repeated_nLOINMODBLE_codec);
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
		if (IOJKDGCFCGG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IOJKDGCFCGG);
		}
		num += nLOINMODBLE_.CalculateSize(_repeated_nLOINMODBLE_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IFJDJKMMABL other)
	{
		if (other != null)
		{
			if (other.IOJKDGCFCGG != 0)
			{
				IOJKDGCFCGG = other.IOJKDGCFCGG;
			}
			nLOINMODBLE_.Add(other.nLOINMODBLE_);
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
			case 24u:
				IOJKDGCFCGG = input.ReadUInt32();
				break;
			case 72u:
			case 74u:
				nLOINMODBLE_.AddEntriesFrom(ref input, _repeated_nLOINMODBLE_codec);
				break;
			}
		}
	}
}
