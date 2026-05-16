using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IJAECOEFEIM : IMessage<IJAECOEFEIM>, IMessage, IEquatable<IJAECOEFEIM>, IDeepCloneable<IJAECOEFEIM>, IBufferMessage
{
	private static readonly MessageParser<IJAECOEFEIM> _parser = new MessageParser<IJAECOEFEIM>(() => new IJAECOEFEIM());

	private UnknownFieldSet _unknownFields;

	public const int ENBGNLBMGFKFieldNumber = 4;

	private JAMLHOHBIGB eNBGNLBMGFK_;

	public const int EAEAFIHIIMKFieldNumber = 12;

	private CDFOGMAMFGF eAEAFIHIIMK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IJAECOEFEIM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IJAECOEFEIMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JAMLHOHBIGB ENBGNLBMGFK
	{
		get
		{
			return eNBGNLBMGFK_;
		}
		set
		{
			eNBGNLBMGFK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CDFOGMAMFGF EAEAFIHIIMK
	{
		get
		{
			return eAEAFIHIIMK_;
		}
		set
		{
			eAEAFIHIIMK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IJAECOEFEIM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IJAECOEFEIM(IJAECOEFEIM other)
		: this()
	{
		eNBGNLBMGFK_ = ((other.eNBGNLBMGFK_ != null) ? other.eNBGNLBMGFK_.Clone() : null);
		eAEAFIHIIMK_ = ((other.eAEAFIHIIMK_ != null) ? other.eAEAFIHIIMK_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IJAECOEFEIM Clone()
	{
		return new IJAECOEFEIM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IJAECOEFEIM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IJAECOEFEIM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(ENBGNLBMGFK, other.ENBGNLBMGFK))
		{
			return false;
		}
		if (!object.Equals(EAEAFIHIIMK, other.EAEAFIHIIMK))
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
		if (eNBGNLBMGFK_ != null)
		{
			num ^= ENBGNLBMGFK.GetHashCode();
		}
		if (eAEAFIHIIMK_ != null)
		{
			num ^= EAEAFIHIIMK.GetHashCode();
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
		if (eNBGNLBMGFK_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(ENBGNLBMGFK);
		}
		if (eAEAFIHIIMK_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(EAEAFIHIIMK);
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
		if (eNBGNLBMGFK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ENBGNLBMGFK);
		}
		if (eAEAFIHIIMK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EAEAFIHIIMK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IJAECOEFEIM other)
	{
		if (other == null)
		{
			return;
		}
		if (other.eNBGNLBMGFK_ != null)
		{
			if (eNBGNLBMGFK_ == null)
			{
				ENBGNLBMGFK = new JAMLHOHBIGB();
			}
			ENBGNLBMGFK.MergeFrom(other.ENBGNLBMGFK);
		}
		if (other.eAEAFIHIIMK_ != null)
		{
			if (eAEAFIHIIMK_ == null)
			{
				EAEAFIHIIMK = new CDFOGMAMFGF();
			}
			EAEAFIHIIMK.MergeFrom(other.EAEAFIHIIMK);
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
			case 34u:
				if (eNBGNLBMGFK_ == null)
				{
					ENBGNLBMGFK = new JAMLHOHBIGB();
				}
				input.ReadMessage(ENBGNLBMGFK);
				break;
			case 98u:
				if (eAEAFIHIIMK_ == null)
				{
					EAEAFIHIIMK = new CDFOGMAMFGF();
				}
				input.ReadMessage(EAEAFIHIIMK);
				break;
			}
		}
	}
}
