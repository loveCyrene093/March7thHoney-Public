using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JDPPGCIEHKF : IMessage<JDPPGCIEHKF>, IMessage, IEquatable<JDPPGCIEHKF>, IDeepCloneable<JDPPGCIEHKF>, IBufferMessage
{
	private static readonly MessageParser<JDPPGCIEHKF> _parser = new MessageParser<JDPPGCIEHKF>(() => new JDPPGCIEHKF());

	private UnknownFieldSet _unknownFields;

	public const int NMNOCJDJKOGFieldNumber = 1;

	private string nMNOCJDJKOG_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JDPPGCIEHKF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JDPPGCIEHKFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string NMNOCJDJKOG
	{
		get
		{
			return nMNOCJDJKOG_;
		}
		set
		{
			nMNOCJDJKOG_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JDPPGCIEHKF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JDPPGCIEHKF(JDPPGCIEHKF other)
		: this()
	{
		nMNOCJDJKOG_ = other.nMNOCJDJKOG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JDPPGCIEHKF Clone()
	{
		return new JDPPGCIEHKF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JDPPGCIEHKF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JDPPGCIEHKF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NMNOCJDJKOG != other.NMNOCJDJKOG)
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
		if (NMNOCJDJKOG.Length != 0)
		{
			num ^= NMNOCJDJKOG.GetHashCode();
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
		if (NMNOCJDJKOG.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(NMNOCJDJKOG);
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
		if (NMNOCJDJKOG.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(NMNOCJDJKOG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JDPPGCIEHKF other)
	{
		if (other != null)
		{
			if (other.NMNOCJDJKOG.Length != 0)
			{
				NMNOCJDJKOG = other.NMNOCJDJKOG;
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				NMNOCJDJKOG = input.ReadString();
			}
		}
	}
}
