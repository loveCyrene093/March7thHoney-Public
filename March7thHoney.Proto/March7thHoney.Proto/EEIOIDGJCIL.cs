using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EEIOIDGJCIL : IMessage<EEIOIDGJCIL>, IMessage, IEquatable<EEIOIDGJCIL>, IDeepCloneable<EEIOIDGJCIL>, IBufferMessage
{
	private static readonly MessageParser<EEIOIDGJCIL> _parser = new MessageParser<EEIOIDGJCIL>(() => new EEIOIDGJCIL());

	private UnknownFieldSet _unknownFields;

	public const int JCACDBFANCBFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_jCACDBFANCB_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> jCACDBFANCB_ = new RepeatedField<uint>();

	public const int GDIGKKGLLOFFieldNumber = 15;

	private KHHHFHEODED gDIGKKGLLOF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EEIOIDGJCIL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EEIOIDGJCILReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> JCACDBFANCB => jCACDBFANCB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KHHHFHEODED GDIGKKGLLOF
	{
		get
		{
			return gDIGKKGLLOF_;
		}
		set
		{
			gDIGKKGLLOF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EEIOIDGJCIL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EEIOIDGJCIL(EEIOIDGJCIL other)
		: this()
	{
		jCACDBFANCB_ = other.jCACDBFANCB_.Clone();
		gDIGKKGLLOF_ = ((other.gDIGKKGLLOF_ != null) ? other.gDIGKKGLLOF_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EEIOIDGJCIL Clone()
	{
		return new EEIOIDGJCIL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EEIOIDGJCIL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EEIOIDGJCIL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!jCACDBFANCB_.Equals(other.jCACDBFANCB_))
		{
			return false;
		}
		if (!object.Equals(GDIGKKGLLOF, other.GDIGKKGLLOF))
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
		num ^= jCACDBFANCB_.GetHashCode();
		if (gDIGKKGLLOF_ != null)
		{
			num ^= GDIGKKGLLOF.GetHashCode();
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
		jCACDBFANCB_.WriteTo(ref output, _repeated_jCACDBFANCB_codec);
		if (gDIGKKGLLOF_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(GDIGKKGLLOF);
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
		num += jCACDBFANCB_.CalculateSize(_repeated_jCACDBFANCB_codec);
		if (gDIGKKGLLOF_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GDIGKKGLLOF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EEIOIDGJCIL other)
	{
		if (other == null)
		{
			return;
		}
		jCACDBFANCB_.Add(other.jCACDBFANCB_);
		if (other.gDIGKKGLLOF_ != null)
		{
			if (gDIGKKGLLOF_ == null)
			{
				GDIGKKGLLOF = new KHHHFHEODED();
			}
			GDIGKKGLLOF.MergeFrom(other.GDIGKKGLLOF);
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 24u:
			case 26u:
				jCACDBFANCB_.AddEntriesFrom(ref input, _repeated_jCACDBFANCB_codec);
				break;
			case 122u:
				if (gDIGKKGLLOF_ == null)
				{
					GDIGKKGLLOF = new KHHHFHEODED();
				}
				input.ReadMessage(GDIGKKGLLOF);
				break;
			}
		}
	}
}
