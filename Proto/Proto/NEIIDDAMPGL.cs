using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NEIIDDAMPGL : IMessage<NEIIDDAMPGL>, IMessage, IEquatable<NEIIDDAMPGL>, IDeepCloneable<NEIIDDAMPGL>, IBufferMessage
{
	private static readonly MessageParser<NEIIDDAMPGL> _parser = new MessageParser<NEIIDDAMPGL>(() => new NEIIDDAMPGL());

	private UnknownFieldSet _unknownFields;

	public const int GGOKHOBBHHFFieldNumber = 4;

	private HLDONLICNOB gGOKHOBBHHF_;

	public const int PIMAHGFDGCDFieldNumber = 8;

	private JAMLHOHBIGB pIMAHGFDGCD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NEIIDDAMPGL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NEIIDDAMPGLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HLDONLICNOB GGOKHOBBHHF
	{
		get
		{
			return gGOKHOBBHHF_;
		}
		set
		{
			gGOKHOBBHHF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JAMLHOHBIGB PIMAHGFDGCD
	{
		get
		{
			return pIMAHGFDGCD_;
		}
		set
		{
			pIMAHGFDGCD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NEIIDDAMPGL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NEIIDDAMPGL(NEIIDDAMPGL other)
		: this()
	{
		gGOKHOBBHHF_ = other.gGOKHOBBHHF_;
		pIMAHGFDGCD_ = ((other.pIMAHGFDGCD_ != null) ? other.pIMAHGFDGCD_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NEIIDDAMPGL Clone()
	{
		return new NEIIDDAMPGL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NEIIDDAMPGL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NEIIDDAMPGL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GGOKHOBBHHF != other.GGOKHOBBHHF)
		{
			return false;
		}
		if (!object.Equals(PIMAHGFDGCD, other.PIMAHGFDGCD))
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
		if (GGOKHOBBHHF != HLDONLICNOB.Mnelhmebhpk)
		{
			num ^= GGOKHOBBHHF.GetHashCode();
		}
		if (pIMAHGFDGCD_ != null)
		{
			num ^= PIMAHGFDGCD.GetHashCode();
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
		if (GGOKHOBBHHF != HLDONLICNOB.Mnelhmebhpk)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)GGOKHOBBHHF);
		}
		if (pIMAHGFDGCD_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(PIMAHGFDGCD);
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
		if (GGOKHOBBHHF != HLDONLICNOB.Mnelhmebhpk)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)GGOKHOBBHHF);
		}
		if (pIMAHGFDGCD_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PIMAHGFDGCD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NEIIDDAMPGL other)
	{
		if (other == null)
		{
			return;
		}
		if (other.GGOKHOBBHHF != HLDONLICNOB.Mnelhmebhpk)
		{
			GGOKHOBBHHF = other.GGOKHOBBHHF;
		}
		if (other.pIMAHGFDGCD_ != null)
		{
			if (pIMAHGFDGCD_ == null)
			{
				PIMAHGFDGCD = new JAMLHOHBIGB();
			}
			PIMAHGFDGCD.MergeFrom(other.PIMAHGFDGCD);
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
			case 32u:
				GGOKHOBBHHF = (HLDONLICNOB)input.ReadEnum();
				break;
			case 66u:
				if (pIMAHGFDGCD_ == null)
				{
					PIMAHGFDGCD = new JAMLHOHBIGB();
				}
				input.ReadMessage(PIMAHGFDGCD);
				break;
			}
		}
	}
}
