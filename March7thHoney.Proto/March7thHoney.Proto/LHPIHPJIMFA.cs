using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LHPIHPJIMFA : IMessage<LHPIHPJIMFA>, IMessage, IEquatable<LHPIHPJIMFA>, IDeepCloneable<LHPIHPJIMFA>, IBufferMessage
{
	private static readonly MessageParser<LHPIHPJIMFA> _parser = new MessageParser<LHPIHPJIMFA>(() => new LHPIHPJIMFA());

	private UnknownFieldSet _unknownFields;

	public const int KGNDHGKKOMMFieldNumber = 15;

	private BJLIAEJNDJK kGNDHGKKOMM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LHPIHPJIMFA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LHPIHPJIMFAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BJLIAEJNDJK KGNDHGKKOMM
	{
		get
		{
			return kGNDHGKKOMM_;
		}
		set
		{
			kGNDHGKKOMM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LHPIHPJIMFA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LHPIHPJIMFA(LHPIHPJIMFA other)
		: this()
	{
		kGNDHGKKOMM_ = ((other.kGNDHGKKOMM_ != null) ? other.kGNDHGKKOMM_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LHPIHPJIMFA Clone()
	{
		return new LHPIHPJIMFA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LHPIHPJIMFA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LHPIHPJIMFA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(KGNDHGKKOMM, other.KGNDHGKKOMM))
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
		if (kGNDHGKKOMM_ != null)
		{
			num ^= KGNDHGKKOMM.GetHashCode();
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
		if (kGNDHGKKOMM_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(KGNDHGKKOMM);
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
		if (kGNDHGKKOMM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KGNDHGKKOMM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LHPIHPJIMFA other)
	{
		if (other == null)
		{
			return;
		}
		if (other.kGNDHGKKOMM_ != null)
		{
			if (kGNDHGKKOMM_ == null)
			{
				KGNDHGKKOMM = new BJLIAEJNDJK();
			}
			KGNDHGKKOMM.MergeFrom(other.KGNDHGKKOMM);
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
			if (num != 122)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (kGNDHGKKOMM_ == null)
			{
				KGNDHGKKOMM = new BJLIAEJNDJK();
			}
			input.ReadMessage(KGNDHGKKOMM);
		}
	}
}
