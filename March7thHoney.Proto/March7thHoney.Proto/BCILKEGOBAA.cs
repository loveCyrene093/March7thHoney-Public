using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BCILKEGOBAA : IMessage<BCILKEGOBAA>, IMessage, IEquatable<BCILKEGOBAA>, IDeepCloneable<BCILKEGOBAA>, IBufferMessage
{
	private static readonly MessageParser<BCILKEGOBAA> _parser = new MessageParser<BCILKEGOBAA>(() => new BCILKEGOBAA());

	private UnknownFieldSet _unknownFields;

	public const int AOMKCMNMIJOFieldNumber = 4;

	private bool aOMKCMNMIJO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BCILKEGOBAA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BCILKEGOBAAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool AOMKCMNMIJO
	{
		get
		{
			return aOMKCMNMIJO_;
		}
		set
		{
			aOMKCMNMIJO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BCILKEGOBAA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BCILKEGOBAA(BCILKEGOBAA other)
		: this()
	{
		aOMKCMNMIJO_ = other.aOMKCMNMIJO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BCILKEGOBAA Clone()
	{
		return new BCILKEGOBAA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BCILKEGOBAA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BCILKEGOBAA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AOMKCMNMIJO != other.AOMKCMNMIJO)
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
		if (AOMKCMNMIJO)
		{
			num ^= AOMKCMNMIJO.GetHashCode();
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
		if (AOMKCMNMIJO)
		{
			output.WriteRawTag(32);
			output.WriteBool(AOMKCMNMIJO);
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
		if (AOMKCMNMIJO)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BCILKEGOBAA other)
	{
		if (other != null)
		{
			if (other.AOMKCMNMIJO)
			{
				AOMKCMNMIJO = other.AOMKCMNMIJO;
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
			if (num != 32)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				AOMKCMNMIJO = input.ReadBool();
			}
		}
	}
}
