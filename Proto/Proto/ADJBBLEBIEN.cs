using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ADJBBLEBIEN : IMessage<ADJBBLEBIEN>, IMessage, IEquatable<ADJBBLEBIEN>, IDeepCloneable<ADJBBLEBIEN>, IBufferMessage
{
	private static readonly MessageParser<ADJBBLEBIEN> _parser = new MessageParser<ADJBBLEBIEN>(() => new ADJBBLEBIEN());

	private UnknownFieldSet _unknownFields;

	public const int DDMKCOBOMNOFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_dDMKCOBOMNO_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> dDMKCOBOMNO_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ADJBBLEBIEN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ADJBBLEBIENReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DDMKCOBOMNO => dDMKCOBOMNO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ADJBBLEBIEN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ADJBBLEBIEN(ADJBBLEBIEN other)
		: this()
	{
		dDMKCOBOMNO_ = other.dDMKCOBOMNO_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ADJBBLEBIEN Clone()
	{
		return new ADJBBLEBIEN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ADJBBLEBIEN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ADJBBLEBIEN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!dDMKCOBOMNO_.Equals(other.dDMKCOBOMNO_))
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
		num ^= dDMKCOBOMNO_.GetHashCode();
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
		dDMKCOBOMNO_.WriteTo(ref output, _repeated_dDMKCOBOMNO_codec);
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
		num += dDMKCOBOMNO_.CalculateSize(_repeated_dDMKCOBOMNO_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ADJBBLEBIEN other)
	{
		if (other != null)
		{
			dDMKCOBOMNO_.Add(other.dDMKCOBOMNO_);
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
			if (num != 72 && num != 74)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				dDMKCOBOMNO_.AddEntriesFrom(ref input, _repeated_dDMKCOBOMNO_codec);
			}
		}
	}
}
