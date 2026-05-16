using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CMIOBFIHNEC : IMessage<CMIOBFIHNEC>, IMessage, IEquatable<CMIOBFIHNEC>, IDeepCloneable<CMIOBFIHNEC>, IBufferMessage
{
	private static readonly MessageParser<CMIOBFIHNEC> _parser = new MessageParser<CMIOBFIHNEC>(() => new CMIOBFIHNEC());

	private UnknownFieldSet _unknownFields;

	public const int IDFBKEKBABDFieldNumber = 10;

	private uint iDFBKEKBABD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CMIOBFIHNEC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CMIOBFIHNECReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IDFBKEKBABD
	{
		get
		{
			return iDFBKEKBABD_;
		}
		set
		{
			iDFBKEKBABD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CMIOBFIHNEC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CMIOBFIHNEC(CMIOBFIHNEC other)
		: this()
	{
		iDFBKEKBABD_ = other.iDFBKEKBABD_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CMIOBFIHNEC Clone()
	{
		return new CMIOBFIHNEC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CMIOBFIHNEC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CMIOBFIHNEC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IDFBKEKBABD != other.IDFBKEKBABD)
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
		if (IDFBKEKBABD != 0)
		{
			num ^= IDFBKEKBABD.GetHashCode();
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
		if (IDFBKEKBABD != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(IDFBKEKBABD);
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
		if (IDFBKEKBABD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IDFBKEKBABD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CMIOBFIHNEC other)
	{
		if (other != null)
		{
			if (other.IDFBKEKBABD != 0)
			{
				IDFBKEKBABD = other.IDFBKEKBABD;
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
			if (num != 80)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				IDFBKEKBABD = input.ReadUInt32();
			}
		}
	}
}
