using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LKNOFJHGGAD : IMessage<LKNOFJHGGAD>, IMessage, IEquatable<LKNOFJHGGAD>, IDeepCloneable<LKNOFJHGGAD>, IBufferMessage
{
	private static readonly MessageParser<LKNOFJHGGAD> _parser = new MessageParser<LKNOFJHGGAD>(() => new LKNOFJHGGAD());

	private UnknownFieldSet _unknownFields;

	public const int PJCEMNFJOLKFieldNumber = 1;

	private bool pJCEMNFJOLK_;

	public const int JPOKEADJNPIFieldNumber = 14;

	private uint jPOKEADJNPI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LKNOFJHGGAD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LKNOFJHGGADReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool PJCEMNFJOLK
	{
		get
		{
			return pJCEMNFJOLK_;
		}
		set
		{
			pJCEMNFJOLK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JPOKEADJNPI
	{
		get
		{
			return jPOKEADJNPI_;
		}
		set
		{
			jPOKEADJNPI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LKNOFJHGGAD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LKNOFJHGGAD(LKNOFJHGGAD other)
		: this()
	{
		pJCEMNFJOLK_ = other.pJCEMNFJOLK_;
		jPOKEADJNPI_ = other.jPOKEADJNPI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LKNOFJHGGAD Clone()
	{
		return new LKNOFJHGGAD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LKNOFJHGGAD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LKNOFJHGGAD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PJCEMNFJOLK != other.PJCEMNFJOLK)
		{
			return false;
		}
		if (JPOKEADJNPI != other.JPOKEADJNPI)
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
		if (PJCEMNFJOLK)
		{
			num ^= PJCEMNFJOLK.GetHashCode();
		}
		if (JPOKEADJNPI != 0)
		{
			num ^= JPOKEADJNPI.GetHashCode();
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
		if (PJCEMNFJOLK)
		{
			output.WriteRawTag(8);
			output.WriteBool(PJCEMNFJOLK);
		}
		if (JPOKEADJNPI != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(JPOKEADJNPI);
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
		if (PJCEMNFJOLK)
		{
			num += 2;
		}
		if (JPOKEADJNPI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JPOKEADJNPI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LKNOFJHGGAD other)
	{
		if (other != null)
		{
			if (other.PJCEMNFJOLK)
			{
				PJCEMNFJOLK = other.PJCEMNFJOLK;
			}
			if (other.JPOKEADJNPI != 0)
			{
				JPOKEADJNPI = other.JPOKEADJNPI;
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
			case 8u:
				PJCEMNFJOLK = input.ReadBool();
				break;
			case 112u:
				JPOKEADJNPI = input.ReadUInt32();
				break;
			}
		}
	}
}
