using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OOCCLBMLECE : IMessage<OOCCLBMLECE>, IMessage, IEquatable<OOCCLBMLECE>, IDeepCloneable<OOCCLBMLECE>, IBufferMessage
{
	private static readonly MessageParser<OOCCLBMLECE> _parser = new MessageParser<OOCCLBMLECE>(() => new OOCCLBMLECE());

	private UnknownFieldSet _unknownFields;

	public const int LFIDDPDPNIEFieldNumber = 7;

	private bool lFIDDPDPNIE_;

	public const int APEBCDDKGOGFieldNumber = 8;

	private uint aPEBCDDKGOG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OOCCLBMLECE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OOCCLBMLECEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool LFIDDPDPNIE
	{
		get
		{
			return lFIDDPDPNIE_;
		}
		set
		{
			lFIDDPDPNIE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint APEBCDDKGOG
	{
		get
		{
			return aPEBCDDKGOG_;
		}
		set
		{
			aPEBCDDKGOG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OOCCLBMLECE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OOCCLBMLECE(OOCCLBMLECE other)
		: this()
	{
		lFIDDPDPNIE_ = other.lFIDDPDPNIE_;
		aPEBCDDKGOG_ = other.aPEBCDDKGOG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OOCCLBMLECE Clone()
	{
		return new OOCCLBMLECE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OOCCLBMLECE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OOCCLBMLECE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LFIDDPDPNIE != other.LFIDDPDPNIE)
		{
			return false;
		}
		if (APEBCDDKGOG != other.APEBCDDKGOG)
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
		if (LFIDDPDPNIE)
		{
			num ^= LFIDDPDPNIE.GetHashCode();
		}
		if (APEBCDDKGOG != 0)
		{
			num ^= APEBCDDKGOG.GetHashCode();
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
		if (LFIDDPDPNIE)
		{
			output.WriteRawTag(56);
			output.WriteBool(LFIDDPDPNIE);
		}
		if (APEBCDDKGOG != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(APEBCDDKGOG);
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
		if (LFIDDPDPNIE)
		{
			num += 2;
		}
		if (APEBCDDKGOG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(APEBCDDKGOG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OOCCLBMLECE other)
	{
		if (other != null)
		{
			if (other.LFIDDPDPNIE)
			{
				LFIDDPDPNIE = other.LFIDDPDPNIE;
			}
			if (other.APEBCDDKGOG != 0)
			{
				APEBCDDKGOG = other.APEBCDDKGOG;
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
			case 56u:
				LFIDDPDPNIE = input.ReadBool();
				break;
			case 64u:
				APEBCDDKGOG = input.ReadUInt32();
				break;
			}
		}
	}
}
