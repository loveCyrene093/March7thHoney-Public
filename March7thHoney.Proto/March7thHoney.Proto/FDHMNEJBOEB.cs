using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FDHMNEJBOEB : IMessage<FDHMNEJBOEB>, IMessage, IEquatable<FDHMNEJBOEB>, IDeepCloneable<FDHMNEJBOEB>, IBufferMessage
{
	private static readonly MessageParser<FDHMNEJBOEB> _parser = new MessageParser<FDHMNEJBOEB>(() => new FDHMNEJBOEB());

	private UnknownFieldSet _unknownFields;

	public const int HINGMEBIBDLFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_hINGMEBIBDL_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> hINGMEBIBDL_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FDHMNEJBOEB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FDHMNEJBOEBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> HINGMEBIBDL => hINGMEBIBDL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FDHMNEJBOEB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FDHMNEJBOEB(FDHMNEJBOEB other)
		: this()
	{
		hINGMEBIBDL_ = other.hINGMEBIBDL_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FDHMNEJBOEB Clone()
	{
		return new FDHMNEJBOEB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FDHMNEJBOEB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FDHMNEJBOEB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!hINGMEBIBDL_.Equals(other.hINGMEBIBDL_))
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
		num ^= hINGMEBIBDL_.GetHashCode();
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
		hINGMEBIBDL_.WriteTo(ref output, _repeated_hINGMEBIBDL_codec);
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
		num += hINGMEBIBDL_.CalculateSize(_repeated_hINGMEBIBDL_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FDHMNEJBOEB other)
	{
		if (other != null)
		{
			hINGMEBIBDL_.Add(other.hINGMEBIBDL_);
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
			if (num != 96 && num != 98)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				hINGMEBIBDL_.AddEntriesFrom(ref input, _repeated_hINGMEBIBDL_codec);
			}
		}
	}
}
