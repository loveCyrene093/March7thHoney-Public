using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EMMIBLOHOKA : IMessage<EMMIBLOHOKA>, IMessage, IEquatable<EMMIBLOHOKA>, IDeepCloneable<EMMIBLOHOKA>, IBufferMessage
{
	private static readonly MessageParser<EMMIBLOHOKA> _parser = new MessageParser<EMMIBLOHOKA>(() => new EMMIBLOHOKA());

	private UnknownFieldSet _unknownFields;

	public const int DEIFKMPAFHKFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_dEIFKMPAFHK_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> dEIFKMPAFHK_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EMMIBLOHOKA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EMMIBLOHOKAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DEIFKMPAFHK => dEIFKMPAFHK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EMMIBLOHOKA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EMMIBLOHOKA(EMMIBLOHOKA other)
		: this()
	{
		dEIFKMPAFHK_ = other.dEIFKMPAFHK_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EMMIBLOHOKA Clone()
	{
		return new EMMIBLOHOKA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EMMIBLOHOKA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EMMIBLOHOKA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!dEIFKMPAFHK_.Equals(other.dEIFKMPAFHK_))
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
		num ^= dEIFKMPAFHK_.GetHashCode();
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
		dEIFKMPAFHK_.WriteTo(ref output, _repeated_dEIFKMPAFHK_codec);
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
		num += dEIFKMPAFHK_.CalculateSize(_repeated_dEIFKMPAFHK_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EMMIBLOHOKA other)
	{
		if (other != null)
		{
			dEIFKMPAFHK_.Add(other.dEIFKMPAFHK_);
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
			if (num != 88 && num != 90)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				dEIFKMPAFHK_.AddEntriesFrom(ref input, _repeated_dEIFKMPAFHK_codec);
			}
		}
	}
}
