using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CFPKKEMKKPO : IMessage<CFPKKEMKKPO>, IMessage, IEquatable<CFPKKEMKKPO>, IDeepCloneable<CFPKKEMKKPO>, IBufferMessage
{
	private static readonly MessageParser<CFPKKEMKKPO> _parser = new MessageParser<CFPKKEMKKPO>(() => new CFPKKEMKKPO());

	private UnknownFieldSet _unknownFields;

	public const int JGJBDAKAKHJFieldNumber = 6;

	private KKJNFIPPDDO jGJBDAKAKHJ_;

	public const int NFOCNKFAHOPFieldNumber = 12;

	private bool nFOCNKFAHOP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CFPKKEMKKPO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CFPKKEMKKPOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public CFPKKEMKKPO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CFPKKEMKKPO(CFPKKEMKKPO other)
		: this()
	{
		jGJBDAKAKHJ_ = ((other.jGJBDAKAKHJ_ != null) ? other.jGJBDAKAKHJ_.Clone() : null);
		nFOCNKFAHOP_ = other.nFOCNKFAHOP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CFPKKEMKKPO Clone()
	{
		return new CFPKKEMKKPO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CFPKKEMKKPO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CFPKKEMKKPO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(JGJBDAKAKHJ, other.JGJBDAKAKHJ))
		{
			return false;
		}
		if (NFOCNKFAHOP != other.NFOCNKFAHOP)
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
		if (jGJBDAKAKHJ_ != null)
		{
			num ^= JGJBDAKAKHJ.GetHashCode();
		}
		if (NFOCNKFAHOP)
		{
			num ^= NFOCNKFAHOP.GetHashCode();
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
		if (jGJBDAKAKHJ_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(JGJBDAKAKHJ);
		}
		if (NFOCNKFAHOP)
		{
			output.WriteRawTag(96);
			output.WriteBool(NFOCNKFAHOP);
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
		if (jGJBDAKAKHJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JGJBDAKAKHJ);
		}
		if (NFOCNKFAHOP)
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
	public void MergeFrom(CFPKKEMKKPO other)
	{
		if (other == null)
		{
			return;
		}
		if (other.jGJBDAKAKHJ_ != null)
		{
			if (jGJBDAKAKHJ_ == null)
			{
				JGJBDAKAKHJ = new KKJNFIPPDDO();
			}
			JGJBDAKAKHJ.MergeFrom(other.JGJBDAKAKHJ);
		}
		if (other.NFOCNKFAHOP)
		{
			NFOCNKFAHOP = other.NFOCNKFAHOP;
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
			case 50u:
				if (jGJBDAKAKHJ_ == null)
				{
					JGJBDAKAKHJ = new KKJNFIPPDDO();
				}
				input.ReadMessage(JGJBDAKAKHJ);
				break;
			case 96u:
				NFOCNKFAHOP = input.ReadBool();
				break;
			}
		}
	}
}
