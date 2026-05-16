using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightLayerInfo : IMessage<GridFightLayerInfo>, IMessage, IEquatable<GridFightLayerInfo>, IDeepCloneable<GridFightLayerInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightLayerInfo> _parser = new MessageParser<GridFightLayerInfo>(() => new GridFightLayerInfo());

	private UnknownFieldSet _unknownFields;

	public const int RouteIsPendingFieldNumber = 11;

	private bool routeIsPending_;

	public const int RouteInfoFieldNumber = 1965;

	private GridFightRouteInfo routeInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightLayerInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightLayerInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool RouteIsPending
	{
		get
		{
			return routeIsPending_;
		}
		set
		{
			routeIsPending_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightRouteInfo RouteInfo
	{
		get
		{
			return routeInfo_;
		}
		set
		{
			routeInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightLayerInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightLayerInfo(GridFightLayerInfo other)
		: this()
	{
		routeIsPending_ = other.routeIsPending_;
		routeInfo_ = ((other.routeInfo_ != null) ? other.routeInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightLayerInfo Clone()
	{
		return new GridFightLayerInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightLayerInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightLayerInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RouteIsPending != other.RouteIsPending)
		{
			return false;
		}
		if (!object.Equals(RouteInfo, other.RouteInfo))
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
		if (RouteIsPending)
		{
			num ^= RouteIsPending.GetHashCode();
		}
		if (routeInfo_ != null)
		{
			num ^= RouteInfo.GetHashCode();
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
		if (RouteIsPending)
		{
			output.WriteRawTag(88);
			output.WriteBool(RouteIsPending);
		}
		if (routeInfo_ != null)
		{
			output.WriteRawTag(234, 122);
			output.WriteMessage(RouteInfo);
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
		if (RouteIsPending)
		{
			num += 2;
		}
		if (routeInfo_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(RouteInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightLayerInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.RouteIsPending)
		{
			RouteIsPending = other.RouteIsPending;
		}
		if (other.routeInfo_ != null)
		{
			if (routeInfo_ == null)
			{
				RouteInfo = new GridFightRouteInfo();
			}
			RouteInfo.MergeFrom(other.RouteInfo);
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
			case 88u:
				RouteIsPending = input.ReadBool();
				break;
			case 15722u:
				if (routeInfo_ == null)
				{
					RouteInfo = new GridFightRouteInfo();
				}
				input.ReadMessage(RouteInfo);
				break;
			}
		}
	}
}
