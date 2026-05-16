using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AEIMINCOFHF : IMessage<AEIMINCOFHF>, IMessage, IEquatable<AEIMINCOFHF>, IDeepCloneable<AEIMINCOFHF>, IBufferMessage
{
	private static readonly MessageParser<AEIMINCOFHF> _parser = new MessageParser<AEIMINCOFHF>(() => new AEIMINCOFHF());

	private UnknownFieldSet _unknownFields;

	public const int GKFEGIBGEGIFieldNumber = 2;

	private uint gKFEGIBGEGI_;

	public const int PosFieldNumber = 14;

	private JFFONIDPNDA pos_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AEIMINCOFHF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AEIMINCOFHFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GKFEGIBGEGI
	{
		get
		{
			return gKFEGIBGEGI_;
		}
		set
		{
			gKFEGIBGEGI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JFFONIDPNDA Pos
	{
		get
		{
			return pos_;
		}
		set
		{
			pos_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AEIMINCOFHF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AEIMINCOFHF(AEIMINCOFHF other)
		: this()
	{
		gKFEGIBGEGI_ = other.gKFEGIBGEGI_;
		pos_ = other.pos_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AEIMINCOFHF Clone()
	{
		return new AEIMINCOFHF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AEIMINCOFHF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AEIMINCOFHF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GKFEGIBGEGI != other.GKFEGIBGEGI)
		{
			return false;
		}
		if (Pos != other.Pos)
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
		if (GKFEGIBGEGI != 0)
		{
			num ^= GKFEGIBGEGI.GetHashCode();
		}
		if (Pos != JFFONIDPNDA.Pcpdhelpkem)
		{
			num ^= Pos.GetHashCode();
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
		if (GKFEGIBGEGI != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(GKFEGIBGEGI);
		}
		if (Pos != JFFONIDPNDA.Pcpdhelpkem)
		{
			output.WriteRawTag(112);
			output.WriteEnum((int)Pos);
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
		if (GKFEGIBGEGI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GKFEGIBGEGI);
		}
		if (Pos != JFFONIDPNDA.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Pos);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AEIMINCOFHF other)
	{
		if (other != null)
		{
			if (other.GKFEGIBGEGI != 0)
			{
				GKFEGIBGEGI = other.GKFEGIBGEGI;
			}
			if (other.Pos != JFFONIDPNDA.Pcpdhelpkem)
			{
				Pos = other.Pos;
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
			case 16u:
				GKFEGIBGEGI = input.ReadUInt32();
				break;
			case 112u:
				Pos = (JFFONIDPNDA)input.ReadEnum();
				break;
			}
		}
	}
}
