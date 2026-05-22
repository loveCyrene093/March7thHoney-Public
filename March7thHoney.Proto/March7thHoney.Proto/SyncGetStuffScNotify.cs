using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SyncGetStuffScNotify : IMessage<SyncGetStuffScNotify>, IMessage, IEquatable<SyncGetStuffScNotify>, IDeepCloneable<SyncGetStuffScNotify>, IBufferMessage
{
	private static readonly MessageParser<SyncGetStuffScNotify> _parser = new MessageParser<SyncGetStuffScNotify>(() => new SyncGetStuffScNotify());

	private UnknownFieldSet _unknownFields;

	public const int JFGKAMKHHEFFieldNumber = 13;

	private GetStuffType jFGKAMKHHEF_;

	public const int GKFEGIBGEGIFieldNumber = 15;

	private uint gKFEGIBGEGI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SyncGetStuffScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SyncGetStuffScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetStuffType JFGKAMKHHEF
	{
		get
		{
			return jFGKAMKHHEF_;
		}
		set
		{
			jFGKAMKHHEF_ = value;
		}
	}

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
	public SyncGetStuffScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncGetStuffScNotify(SyncGetStuffScNotify other)
		: this()
	{
		jFGKAMKHHEF_ = other.jFGKAMKHHEF_;
		gKFEGIBGEGI_ = other.gKFEGIBGEGI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncGetStuffScNotify Clone()
	{
		return new SyncGetStuffScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SyncGetStuffScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SyncGetStuffScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JFGKAMKHHEF != other.JFGKAMKHHEF)
		{
			return false;
		}
		if (GKFEGIBGEGI != other.GKFEGIBGEGI)
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
		if (JFGKAMKHHEF != GetStuffType.GapdopfogenBljeehfcnco)
		{
			num ^= JFGKAMKHHEF.GetHashCode();
		}
		if (GKFEGIBGEGI != 0)
		{
			num ^= GKFEGIBGEGI.GetHashCode();
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
		if (JFGKAMKHHEF != GetStuffType.GapdopfogenBljeehfcnco)
		{
			output.WriteRawTag(104);
			output.WriteEnum((int)JFGKAMKHHEF);
		}
		if (GKFEGIBGEGI != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(GKFEGIBGEGI);
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
		if (JFGKAMKHHEF != GetStuffType.GapdopfogenBljeehfcnco)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)JFGKAMKHHEF);
		}
		if (GKFEGIBGEGI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GKFEGIBGEGI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SyncGetStuffScNotify other)
	{
		if (other != null)
		{
			if (other.JFGKAMKHHEF != GetStuffType.GapdopfogenBljeehfcnco)
			{
				JFGKAMKHHEF = other.JFGKAMKHHEF;
			}
			if (other.GKFEGIBGEGI != 0)
			{
				GKFEGIBGEGI = other.GKFEGIBGEGI;
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
			case 104u:
				JFGKAMKHHEF = (GetStuffType)input.ReadEnum();
				break;
			case 120u:
				GKFEGIBGEGI = input.ReadUInt32();
				break;
			}
		}
	}
}
