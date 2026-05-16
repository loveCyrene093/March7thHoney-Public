using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PCKIOEGAPAI : IMessage<PCKIOEGAPAI>, IMessage, IEquatable<PCKIOEGAPAI>, IDeepCloneable<PCKIOEGAPAI>, IBufferMessage
{
	private static readonly MessageParser<PCKIOEGAPAI> _parser = new MessageParser<PCKIOEGAPAI>(() => new PCKIOEGAPAI());

	private UnknownFieldSet _unknownFields;

	public const int CIGCKKGMLIDFieldNumber = 13;

	private static readonly FieldCodec<BDDBAKBOMKP> _repeated_cIGCKKGMLID_codec = FieldCodec.ForMessage(106u, BDDBAKBOMKP.Parser);

	private readonly RepeatedField<BDDBAKBOMKP> cIGCKKGMLID_ = new RepeatedField<BDDBAKBOMKP>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PCKIOEGAPAI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PCKIOEGAPAIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BDDBAKBOMKP> CIGCKKGMLID => cIGCKKGMLID_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PCKIOEGAPAI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PCKIOEGAPAI(PCKIOEGAPAI other)
		: this()
	{
		cIGCKKGMLID_ = other.cIGCKKGMLID_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PCKIOEGAPAI Clone()
	{
		return new PCKIOEGAPAI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PCKIOEGAPAI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PCKIOEGAPAI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!cIGCKKGMLID_.Equals(other.cIGCKKGMLID_))
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
		num ^= cIGCKKGMLID_.GetHashCode();
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
		cIGCKKGMLID_.WriteTo(ref output, _repeated_cIGCKKGMLID_codec);
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
		num += cIGCKKGMLID_.CalculateSize(_repeated_cIGCKKGMLID_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PCKIOEGAPAI other)
	{
		if (other != null)
		{
			cIGCKKGMLID_.Add(other.cIGCKKGMLID_);
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
			if (num != 106)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				cIGCKKGMLID_.AddEntriesFrom(ref input, _repeated_cIGCKKGMLID_codec);
			}
		}
	}
}
