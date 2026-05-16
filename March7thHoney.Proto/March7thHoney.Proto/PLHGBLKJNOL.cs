using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PLHGBLKJNOL : IMessage<PLHGBLKJNOL>, IMessage, IEquatable<PLHGBLKJNOL>, IDeepCloneable<PLHGBLKJNOL>, IBufferMessage
{
	private static readonly MessageParser<PLHGBLKJNOL> _parser = new MessageParser<PLHGBLKJNOL>(() => new PLHGBLKJNOL());

	private UnknownFieldSet _unknownFields;

	public const int InteractedPropEntityIdFieldNumber = 10;

	private uint interactedPropEntityId_;

	public const int DOMGLHIKJEDFieldNumber = 13;

	private uint dOMGLHIKJED_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PLHGBLKJNOL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PLHGBLKJNOLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint InteractedPropEntityId
	{
		get
		{
			return interactedPropEntityId_;
		}
		set
		{
			interactedPropEntityId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DOMGLHIKJED
	{
		get
		{
			return dOMGLHIKJED_;
		}
		set
		{
			dOMGLHIKJED_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PLHGBLKJNOL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PLHGBLKJNOL(PLHGBLKJNOL other)
		: this()
	{
		interactedPropEntityId_ = other.interactedPropEntityId_;
		dOMGLHIKJED_ = other.dOMGLHIKJED_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PLHGBLKJNOL Clone()
	{
		return new PLHGBLKJNOL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PLHGBLKJNOL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PLHGBLKJNOL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (InteractedPropEntityId != other.InteractedPropEntityId)
		{
			return false;
		}
		if (DOMGLHIKJED != other.DOMGLHIKJED)
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
		if (InteractedPropEntityId != 0)
		{
			num ^= InteractedPropEntityId.GetHashCode();
		}
		if (DOMGLHIKJED != 0)
		{
			num ^= DOMGLHIKJED.GetHashCode();
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
		if (InteractedPropEntityId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(InteractedPropEntityId);
		}
		if (DOMGLHIKJED != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(DOMGLHIKJED);
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
		if (InteractedPropEntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(InteractedPropEntityId);
		}
		if (DOMGLHIKJED != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DOMGLHIKJED);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PLHGBLKJNOL other)
	{
		if (other != null)
		{
			if (other.InteractedPropEntityId != 0)
			{
				InteractedPropEntityId = other.InteractedPropEntityId;
			}
			if (other.DOMGLHIKJED != 0)
			{
				DOMGLHIKJED = other.DOMGLHIKJED;
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
			case 80u:
				InteractedPropEntityId = input.ReadUInt32();
				break;
			case 104u:
				DOMGLHIKJED = input.ReadUInt32();
				break;
			}
		}
	}
}
