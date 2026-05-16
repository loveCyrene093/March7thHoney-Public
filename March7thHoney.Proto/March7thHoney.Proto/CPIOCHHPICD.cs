using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CPIOCHHPICD : IMessage<CPIOCHHPICD>, IMessage, IEquatable<CPIOCHHPICD>, IDeepCloneable<CPIOCHHPICD>, IBufferMessage
{
	private static readonly MessageParser<CPIOCHHPICD> _parser = new MessageParser<CPIOCHHPICD>(() => new CPIOCHHPICD());

	private UnknownFieldSet _unknownFields;

	public const int BIKHOEGFEFDFieldNumber = 3;

	private FBBMDFDOEEF bIKHOEGFEFD_;

	public const int LEKLKNKEBPOFieldNumber = 14;

	private FIGFDNBIHCF lEKLKNKEBPO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CPIOCHHPICD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CPIOCHHPICDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FBBMDFDOEEF BIKHOEGFEFD
	{
		get
		{
			return bIKHOEGFEFD_;
		}
		set
		{
			bIKHOEGFEFD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FIGFDNBIHCF LEKLKNKEBPO
	{
		get
		{
			return lEKLKNKEBPO_;
		}
		set
		{
			lEKLKNKEBPO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CPIOCHHPICD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CPIOCHHPICD(CPIOCHHPICD other)
		: this()
	{
		bIKHOEGFEFD_ = ((other.bIKHOEGFEFD_ != null) ? other.bIKHOEGFEFD_.Clone() : null);
		lEKLKNKEBPO_ = ((other.lEKLKNKEBPO_ != null) ? other.lEKLKNKEBPO_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CPIOCHHPICD Clone()
	{
		return new CPIOCHHPICD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CPIOCHHPICD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CPIOCHHPICD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(BIKHOEGFEFD, other.BIKHOEGFEFD))
		{
			return false;
		}
		if (!object.Equals(LEKLKNKEBPO, other.LEKLKNKEBPO))
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
		if (bIKHOEGFEFD_ != null)
		{
			num ^= BIKHOEGFEFD.GetHashCode();
		}
		if (lEKLKNKEBPO_ != null)
		{
			num ^= LEKLKNKEBPO.GetHashCode();
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
		if (bIKHOEGFEFD_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(BIKHOEGFEFD);
		}
		if (lEKLKNKEBPO_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(LEKLKNKEBPO);
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
		if (bIKHOEGFEFD_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BIKHOEGFEFD);
		}
		if (lEKLKNKEBPO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LEKLKNKEBPO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CPIOCHHPICD other)
	{
		if (other == null)
		{
			return;
		}
		if (other.bIKHOEGFEFD_ != null)
		{
			if (bIKHOEGFEFD_ == null)
			{
				BIKHOEGFEFD = new FBBMDFDOEEF();
			}
			BIKHOEGFEFD.MergeFrom(other.BIKHOEGFEFD);
		}
		if (other.lEKLKNKEBPO_ != null)
		{
			if (lEKLKNKEBPO_ == null)
			{
				LEKLKNKEBPO = new FIGFDNBIHCF();
			}
			LEKLKNKEBPO.MergeFrom(other.LEKLKNKEBPO);
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
			case 26u:
				if (bIKHOEGFEFD_ == null)
				{
					BIKHOEGFEFD = new FBBMDFDOEEF();
				}
				input.ReadMessage(BIKHOEGFEFD);
				break;
			case 114u:
				if (lEKLKNKEBPO_ == null)
				{
					LEKLKNKEBPO = new FIGFDNBIHCF();
				}
				input.ReadMessage(LEKLKNKEBPO);
				break;
			}
		}
	}
}
