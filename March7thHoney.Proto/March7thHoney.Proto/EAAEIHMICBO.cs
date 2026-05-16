using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EAAEIHMICBO : IMessage<EAAEIHMICBO>, IMessage, IEquatable<EAAEIHMICBO>, IDeepCloneable<EAAEIHMICBO>, IBufferMessage
{
	private static readonly MessageParser<EAAEIHMICBO> _parser = new MessageParser<EAAEIHMICBO>(() => new EAAEIHMICBO());

	private UnknownFieldSet _unknownFields;

	public const int EAEAFIHIIMKFieldNumber = 4;

	private LNOBPFKAAGA eAEAFIHIIMK_;

	public const int ENBGNLBMGFKFieldNumber = 10;

	private JAMLHOHBIGB eNBGNLBMGFK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EAAEIHMICBO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EAAEIHMICBOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LNOBPFKAAGA EAEAFIHIIMK
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
	public EAAEIHMICBO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EAAEIHMICBO(EAAEIHMICBO other)
		: this()
	{
		eAEAFIHIIMK_ = ((other.eAEAFIHIIMK_ != null) ? other.eAEAFIHIIMK_.Clone() : null);
		eNBGNLBMGFK_ = ((other.eNBGNLBMGFK_ != null) ? other.eNBGNLBMGFK_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EAAEIHMICBO Clone()
	{
		return new EAAEIHMICBO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EAAEIHMICBO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EAAEIHMICBO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(EAEAFIHIIMK, other.EAEAFIHIIMK))
		{
			return false;
		}
		if (!object.Equals(ENBGNLBMGFK, other.ENBGNLBMGFK))
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
		if (eAEAFIHIIMK_ != null)
		{
			num ^= EAEAFIHIIMK.GetHashCode();
		}
		if (eNBGNLBMGFK_ != null)
		{
			num ^= ENBGNLBMGFK.GetHashCode();
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
		if (eAEAFIHIIMK_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(EAEAFIHIIMK);
		}
		if (eNBGNLBMGFK_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(ENBGNLBMGFK);
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
		if (eAEAFIHIIMK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EAEAFIHIIMK);
		}
		if (eNBGNLBMGFK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ENBGNLBMGFK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EAAEIHMICBO other)
	{
		if (other == null)
		{
			return;
		}
		if (other.eAEAFIHIIMK_ != null)
		{
			if (eAEAFIHIIMK_ == null)
			{
				EAEAFIHIIMK = new LNOBPFKAAGA();
			}
			EAEAFIHIIMK.MergeFrom(other.EAEAFIHIIMK);
		}
		if (other.eNBGNLBMGFK_ != null)
		{
			if (eNBGNLBMGFK_ == null)
			{
				ENBGNLBMGFK = new JAMLHOHBIGB();
			}
			ENBGNLBMGFK.MergeFrom(other.ENBGNLBMGFK);
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
				if (eAEAFIHIIMK_ == null)
				{
					EAEAFIHIIMK = new LNOBPFKAAGA();
				}
				input.ReadMessage(EAEAFIHIIMK);
				break;
			case 82u:
				if (eNBGNLBMGFK_ == null)
				{
					ENBGNLBMGFK = new JAMLHOHBIGB();
				}
				input.ReadMessage(ENBGNLBMGFK);
				break;
			}
		}
	}
}
