using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ACFGJBNMFDC : IMessage<ACFGJBNMFDC>, IMessage, IEquatable<ACFGJBNMFDC>, IDeepCloneable<ACFGJBNMFDC>, IBufferMessage
{
	private static readonly MessageParser<ACFGJBNMFDC> _parser = new MessageParser<ACFGJBNMFDC>(() => new ACFGJBNMFDC());

	private UnknownFieldSet _unknownFields;

	public const int NFOCNKFAHOPFieldNumber = 1;

	private bool nFOCNKFAHOP_;

	public const int JGJBDAKAKHJFieldNumber = 9;

	private KKJNFIPPDDO jGJBDAKAKHJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ACFGJBNMFDC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ACFGJBNMFDCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool NFOCNKFAHOP
	{
		get
		{
			return nFOCNKFAHOP_;
		}
		set
		{
			nFOCNKFAHOP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KKJNFIPPDDO JGJBDAKAKHJ
	{
		get
		{
			return jGJBDAKAKHJ_;
		}
		set
		{
			jGJBDAKAKHJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ACFGJBNMFDC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ACFGJBNMFDC(ACFGJBNMFDC other)
		: this()
	{
		nFOCNKFAHOP_ = other.nFOCNKFAHOP_;
		jGJBDAKAKHJ_ = ((other.jGJBDAKAKHJ_ != null) ? other.jGJBDAKAKHJ_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ACFGJBNMFDC Clone()
	{
		return new ACFGJBNMFDC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ACFGJBNMFDC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ACFGJBNMFDC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NFOCNKFAHOP != other.NFOCNKFAHOP)
		{
			return false;
		}
		if (!object.Equals(JGJBDAKAKHJ, other.JGJBDAKAKHJ))
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
		if (NFOCNKFAHOP)
		{
			num ^= NFOCNKFAHOP.GetHashCode();
		}
		if (jGJBDAKAKHJ_ != null)
		{
			num ^= JGJBDAKAKHJ.GetHashCode();
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
		if (NFOCNKFAHOP)
		{
			output.WriteRawTag(8);
			output.WriteBool(NFOCNKFAHOP);
		}
		if (jGJBDAKAKHJ_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(JGJBDAKAKHJ);
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
		if (NFOCNKFAHOP)
		{
			num += 2;
		}
		if (jGJBDAKAKHJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JGJBDAKAKHJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ACFGJBNMFDC other)
	{
		if (other == null)
		{
			return;
		}
		if (other.NFOCNKFAHOP)
		{
			NFOCNKFAHOP = other.NFOCNKFAHOP;
		}
		if (other.jGJBDAKAKHJ_ != null)
		{
			if (jGJBDAKAKHJ_ == null)
			{
				JGJBDAKAKHJ = new KKJNFIPPDDO();
			}
			JGJBDAKAKHJ.MergeFrom(other.JGJBDAKAKHJ);
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
			case 8u:
				NFOCNKFAHOP = input.ReadBool();
				break;
			case 74u:
				if (jGJBDAKAKHJ_ == null)
				{
					JGJBDAKAKHJ = new KKJNFIPPDDO();
				}
				input.ReadMessage(JGJBDAKAKHJ);
				break;
			}
		}
	}
}
