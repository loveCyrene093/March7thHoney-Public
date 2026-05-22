using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LOPOJDAAIPO : IMessage<LOPOJDAAIPO>, IMessage, IEquatable<LOPOJDAAIPO>, IDeepCloneable<LOPOJDAAIPO>, IBufferMessage
{
	private static readonly MessageParser<LOPOJDAAIPO> _parser = new MessageParser<LOPOJDAAIPO>(() => new LOPOJDAAIPO());

	private UnknownFieldSet _unknownFields;

	public const int AHBFAAMNKNOFieldNumber = 1;

	private BGKINCFGKGI aHBFAAMNKNO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LOPOJDAAIPO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LOPOJDAAIPOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BGKINCFGKGI AHBFAAMNKNO
	{
		get
		{
			return aHBFAAMNKNO_;
		}
		set
		{
			aHBFAAMNKNO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LOPOJDAAIPO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LOPOJDAAIPO(LOPOJDAAIPO other)
		: this()
	{
		aHBFAAMNKNO_ = ((other.aHBFAAMNKNO_ != null) ? other.aHBFAAMNKNO_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LOPOJDAAIPO Clone()
	{
		return new LOPOJDAAIPO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LOPOJDAAIPO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LOPOJDAAIPO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(AHBFAAMNKNO, other.AHBFAAMNKNO))
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
		if (aHBFAAMNKNO_ != null)
		{
			num ^= AHBFAAMNKNO.GetHashCode();
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
		if (aHBFAAMNKNO_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(AHBFAAMNKNO);
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
		if (aHBFAAMNKNO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AHBFAAMNKNO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LOPOJDAAIPO other)
	{
		if (other == null)
		{
			return;
		}
		if (other.aHBFAAMNKNO_ != null)
		{
			if (aHBFAAMNKNO_ == null)
			{
				AHBFAAMNKNO = new BGKINCFGKGI();
			}
			AHBFAAMNKNO.MergeFrom(other.AHBFAAMNKNO);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (aHBFAAMNKNO_ == null)
			{
				AHBFAAMNKNO = new BGKINCFGKGI();
			}
			input.ReadMessage(AHBFAAMNKNO);
		}
	}
}
